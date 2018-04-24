using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Node<tipo>
    {
        private tipo info =  default(tipo);
        private Node<tipo> hijoDerecho = default(Node<tipo>);
        private Node<tipo> hijoIzquierdo = default(Node<tipo>);

        public Node()
        {
            info = default(tipo);
            hijoDerecho = default(Node<tipo>);
            hijoIzquierdo = default(Node<tipo>);
        }
        public Node(tipo content)
        {
            info = content;
            hijoDerecho = null;
            hijoIzquierdo = null;
        }
        public tipo Contenido { get; set; }
        public Node<tipo> HijoDerecho { get; set; }
        public Node<tipo> HijoIzquierdo { get; set; }
        public Node<tipo> nodePadre(Node<tipo> node)
        {
            return node;
        }
        

    }
}
