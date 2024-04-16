using RolaDados.Models;
using System.Runtime.CompilerServices;

namespace RolaDados
{
    public partial class MainPage : ContentPage
    {
        string escolha = "";
        int escolhaResultado = 0;

        public MainPage()
        {
            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }

        private void dadoBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            escolha = SidesPicker.SelectedItem.ToString();
            int rnd = new Coin().Girar();
            EscolhaResultado("Cara");
            ExibirMensagem(rnd);
            TrocarImagem(rnd);


        }


        private void EscolhaResultado(string escolhaUsuario)
        {

            if (escolha == escolhaUsuario)
            {
                escolhaResultado = (int)CoinType.CARA;

            }

            else
            {
                escolhaResultado = (int)CoinType.COROA;
            }


        }

        private void ExibirMensagem(int rnd)
        {
            if (escolhaResultado == rnd)
            {
                Result.Text = $"Deu {escolha}, Você venceu";
            }
            else
            {
                Result.Text = $"Que pena, não deu {escolha}, Voce perdeu";
            }

        }

        private void TrocarImagem(int rnd)
        {
            switch (rnd)
            {
                case (int)CoinType.CARA:
                default:
                    CoinImage.Source = "cara.jpg";
                    break;
                case (int)CoinType.COROA:
                    CoinImage.Source = "coroa.jpg";
                    break;
            }
        }
    }
}
