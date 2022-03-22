using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobAvaliacao
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async Task<bool> FazerLoginAsync()
        {
            bool logando = false;
            try
            {
                if (String.IsNullOrEmpty(txtEmail.Text))
                    throw new Exception("Login não informado");
                if (String.IsNullOrEmpty(txtSenha.Text))
                    throw new Exception("Senha não informada");

                string _email = txtEmail.Text;
                string _senha = txtSenha.Text;

                //ServiceUsuario u = new ServiceUsuario(App.dbPath);

                //logando = u.ComparaLogin(_email, _senha);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
            return logando;
        }

        private async void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            /*bool logou = await FazerLoginAsync();
            ModelConfiguracao cNovo = new ModelConfiguracao();
            ModelConfiguracao cOld;
            ModelUsuario mU;
            ModelProfissional mP;

            if (logou)
            {
                try
                {
                    ServiceConfiguracao dbConfig = new ServiceConfiguracao(App.dbPath);
                    ServiceUsuario u = new ServiceUsuario(App.dbPath);
                    ServiceProfissional p = new ServiceProfissional(App.dbPath);


                    mU = u.PegaUsuario(txtEmail.Text, txtSenha.Text);

                    cNovo.IdUsuario = mU.IdUsuario;
                    cOld = dbConfig.PegaConfig(cNovo.IdUsuario); //se tiver mesmo ID, pega a configuração ja existente

                    if (cOld.IdUsuario <= 0)
                    {
                        mP = p.PegaProfissional(mU.IdEntidade);

                        cNovo.IdEntidade = mU.IdEntidade;
                        cNovo.IdProfissional = mP.IdProfiossional;
                        cNovo.IdUsuario = mU.IdUsuario;
                        cNovo.ManterLogado = false;
                        cNovo.ModoDark = false;

                        //inserir nova configuração
                        dbConfig.Inserir(cNovo);
                        App.Globais._configuracao = cNovo;
                    }
                    else
                        App.Globais._configuracao = cOld; //pegando config existente do usuario no banco 
                    Application.Current.MainPage = new Home();
                }
                catch (Exception ex)
                {
                    throw new Exception(string.Format("Erro: {0}", ex.Message));
                }
            }


            else
                await DisplayAlert("Erro ao logar", "Conta não encontrada!\nVerifique os dados informados e tente novamente", "OK");*/
        }

        /*private void ManterLogado_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            App.Global.logado = true;
            ckbManterLogado.IsChecked = true;
        }*/

        private async void BtnCadastrar_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CadastrarUsuarioDados());
        }
    }
}
