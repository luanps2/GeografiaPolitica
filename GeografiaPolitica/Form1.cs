using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeografiaPolitica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String imagem = "";
        String texto = "";

        public void mudarPais(String pais, String txt) {

            imagem = pais + ".png";

            if (brasil.Checked == true)
            {
                pais = "brasil";
                texto = "O Brasil, um vasto país sul-americano, estende-se da Bacia Amazônica, " +
                    "no norte, até os vinhedos e as gigantescas Cataratas do Iguaçu, no sul. " +
                    "O Rio de Janeiro, simbolizado pela sua estátua de 38 metros de altura do Cristo Redentor, " +
                    "situada no topo do Corcovado, é famoso pelas movimentadas praias de Copacabana e Ipanema, " +
                    "bem como pelo imenso e animado Carnaval, com desfiles de carros alegóricos, fantasias extravagantes e samba.";
            }
            else if (chile.Checked == true)
            {
                pais = "chile";
                texto = "A bandeira nacional do Chile apresenta duas listas " +
                    "horizontais iguais de branco e vermelho, com um quadrado azul com a mesma altura da " +
                    "lista branca no canto superior esquerdo, contendo uma estrela branca de cinco pontas, ou seja, um pentagrama.";
            }
            else if (mexico.Checked == true)
            {
                pais = "mexico";
                texto = "O México é um país situado entre os Estados Unidos e a América Central, conhecido pelas praias no Pacífico e no " +
                    "Golfo do México e pela paisagem diversificada que inclui montanhas, desertos e selvas. " +
                    "Ruínas antigas, como Teotihuacán e a cidade maia de Chichén Itzá, estão espalhadas pelo país, " +
                    "assim como cidades da era colonial espanhola. Na capital, Cidade do México, lojas elegantes, " +
                    "museus renomados e restaurantes gourmet atendem às necessidades da vida moderna.";
            }
            else if (argentina.Checked == true)
            {
                pais = "argentina";
                texto = "Argentina, oficialmente República Argentina (pronunciado em espanhol: [reˈpuβlika aɾxenˈtina]), " +
                    "é o segundo maior país da América do Sul em território e o terceiro em população, " +
                    "constituída como uma federação de 23 províncias e uma cidade autônoma, Buenos Aires, " +
                    "capital do país. É o oitavo maior país do mundo em área territorial e o maior entre as nações de língua espanhola, " +
                    "embora México, Colômbia e Espanha, que possuem menor território, sejam mais populosos.";
            }

            pbImagem.Load("../../Resources/" + imagem);
            txtTexto.Text = texto;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mudarPais("brasil", texto);
        }

        private void gbPais_Enter(object sender, EventArgs e)
        {

        }

        private void chile_CheckedChanged(object sender, EventArgs e)
        {
            mudarPais("chile", texto);
        }

        private void mexico_CheckedChanged(object sender, EventArgs e)
        {
            mudarPais("mexico", texto);
        }

        private void argentina_CheckedChanged(object sender, EventArgs e)
        {
            mudarPais("argentina", texto);
        }
    }
}
