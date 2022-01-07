using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalJornadaOcean.Model
{
    internal class Elevador
    {
        private int andares, capacidade;
        private string status = "Aguardando.";
        //private int qtdPessoas = 0;

        public int AndarAtual { get; set; }
        public int Pessoas { get; set; }
        //O usuário vai informar quantos andares o elevador possui e a capacidade de pessoas.
        public void Inicializar(int qtdAndares, int qtdMaxPessoas) {
            //deve receber como parâmetros a capacidade do elevador e o total de
            //andares no prédio(os elevadores sempre começam no térreo e vazio);
            andares = qtdAndares;
            capacidade = qtdMaxPessoas;

            Console.WriteLine($"Quantidade de andares: {andares}\nCapacidade máxima de pessoas: {capacidade}");
        }
        public string Status() {
            return status;
        }
        public void Entrar() {
            //deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);

            //verifica se tem espaço no elevador
            if (Pessoas < capacidade) {
                status = "Uma pessoa entrou no elevador.";
                Pessoas++;
            }else{
                status = "Elevador cheio.";
            }
        }

        public void Sair() {
            //deve remover uma pessoa do elevador(só deve remover se houver alguém dentro dele);
            if (Pessoas == 0) {
                status = "O elevador encontra-se vazio.";
            }else{
                Pessoas--;
            }
        }

        public void Subir() {
            //deve subir um andar ( nao deve subir se ja estiver no ultimo andar)
            if (andares == AndarAtual) {
                status = "O elevador já está no ultimo andar e não pode mais subir.";
            }else {

                status = $"Elevador está saindo do {AndarAtual} e subindo para o: {++AndarAtual}";
                //andarAtual++;
            }
        }

        public void Descer() {
            //Deve descer um andar (não deve descer se já estiver no térreo.)
            if (AndarAtual == 0) {
                status = "Elevador está no terreo";
                //AndarAtual--; 
            }else {
                status = $"Elevador está saindo do {AndarAtual} e subindo para o: {AndarAtual--}";
            }
        }
    }
}
