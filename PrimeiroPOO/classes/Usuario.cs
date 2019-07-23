namespace PrimeiroPOO.classes
{
    public class Usuario
    {
        //Atributos da classe usuário
        string login;
        string senha;
        string acesso;

        //Funções, operações, métodos que serão executados pelos usuários
        /// <summary>
        /// O método cadastrar realiza o cadastro do usuário e retorna uma mensagem.
        /// </summary>
        /// <returns>Cadastrado ou Não</returns>
        string cadastrar(){
            string msg = "";
            if(login.Equals("") || senha.Equals("") || acesso.Equals("")){
                msg = "Preencha todos os campos. Tente outra vez!";
            }
            else{
                msg = "Dados cadastrados com sucesso!";
            }
            return msg;
        }

        /// <summary>
        /// O método atualizarSenha realiza a modificação da senha atual do usuário
        /// </summary>
        /// <param name="novaSenha">Você deve passar a senha entre aspas</param>
        /// <returns>Mensagem de alteração com sucesso ou não</returns>
        string atualizarSenha(string novaSenha){
            string msg="";
            if(novaSenha.Equals("")){
                msg = "Você deve passar a nova senha";
            }
            else{
                senha = novaSenha;
                msg="Senha alterada com sucesso!";
            }
            return msg;
        }

    /// <summary>
    /// O método logar permite ao usuário acessar o sistema.
    /// </summary>
    /// <param name="lg">Passe o nome de usuário entre aspas</param>
    /// <param name="sn">Passe a senha entre aspas</param>
    /// <returns>Mensagem logado com sucesso ou não</returns>
        string logar(string lg, string sn){
            string msg="";
            
            if(!login.Equals(lg) || !senha.Equals(sn)){
                msg = "Nome de usuário ou senha incorretos";
            }
            else{
                msg = "Login realizado com sucesso!";
            }
            return msg;
        }

        /// <summary>
        /// O método logout permite ao usuário sair do sistema.
        /// </summary>
        /// <returns>Mensagem de saída</returns>
        string logout(){
            login = "";
            senha = "";
            acesso = "";
            return "Logout realizado com sucesso!";
        }
    }
}