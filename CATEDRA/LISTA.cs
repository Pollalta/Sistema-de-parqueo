using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATEDRA
{
    internal class LISTA
    {
        public NODO aElemento;
        public LISTA aSubLista;
        public int aPeso;

        public LISTA()
        {
            aElemento = null;
            aSubLista = null;
            aPeso = 0;
        }

        public LISTA(LISTA pLista)
        {
            if (pLista != null)
            {
                aElemento = pLista.aElemento;
                aSubLista = pLista.aSubLista;
                aPeso = pLista.aPeso;
            }
        }

        public LISTA(NODO pElemento, LISTA pSubLista, int pPeso)
        {
            aElemento = pElemento;
            aSubLista = pSubLista;
            aPeso = pPeso;
        }

        public int NroElementos()
        {
            if (aElemento != null)
            {
                return 1 + aSubLista.NroElementos();
            }
            else
            {
                return 0;
            }
        }

        public object lesimoElemento(int posicion)
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                {
                    return aElemento;
                }
                else
                {
                    return aSubLista.lesimoElemento(posicion - 1);
                }
            }
            else
            {
                return null;
            }
        }

        public object lesimoElementoPeso(int posicion)
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                {
                    return aPeso;
                }
                else
                {
                    return aSubLista.lesimoElementoPeso(posicion - 1);
                }
            }
            else
            {
                return 0;
            }
        }

        public bool ExisteElemento(NODO pElemento)
        {
            if ((aElemento != null) && (pElemento != null))
            {
                return (aElemento.Equals(pElemento) || (aSubLista.ExisteElemento(pElemento)));
            }
            else
            {
                return false;
            }
        }

        public void Agregar(NODO pElemento, int pPeso)
        {
            if (pElemento != null)
            {
                if (aElemento == null)
                {
                    aElemento = new NODO(pElemento.nombre);
                    aPeso = pPeso;
                    aSubLista = new LISTA();
                }
                else
                {
                    if (!ExisteElemento(pElemento))
                    {
                        aSubLista.Agregar(pElemento, pPeso);
                    }
                }
            }
        }

        public int PosicionElemento(NODO pElemento)
        {
            if ((aElemento != null) || (ExisteElemento(pElemento)))
            {
                if (aElemento.Equals(pElemento))
                {
                    return 1;
                }
                else
                {
                    return 1 + aSubLista.PosicionElemento(pElemento);
                }
            }
            else
            {
                return 0;
            }
        }


    }
}
