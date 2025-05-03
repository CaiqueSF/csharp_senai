namespace JogoDaVelhaApp {
	public class JogoDaVelha {

		private bool fimJogo;
		private char[] posicoes;
		private char jogador;
		private int quantidadePreenchida;


		// MÉTODO CONSTRUTOR
		public JogoDaVelha() {
			fimJogo = false;
			posicoes = new[] {
				'1', '2', '3',
				'4', '5', '6',
				'7', '8', '9'
			};
			jogador = 'X';
			quantidadePreenchida = 0;
		}


		// MÉTODO PARA RENDERIZAÇÃO DA TABELA
		private void renderiza_tabela() {
			Console.Clear();
			Console.WriteLine("X O X O X O X O X O X O  JOGO DA VELHA  X O X O X O X O X O X O");
			Console.WriteLine(ObterTabela());
		}

		private string ObterTabela() {
			return @$"
			[{posicoes[0]}] | [{posicoes[1]}] | [{posicoes[2]}]
			---------------
			[{posicoes[3]}] | [{posicoes[4]}] | [{posicoes[5]}]
			---------------
			[{posicoes[6]}] | [{posicoes[7]}] | [{posicoes[8]}]
			";
		}


		// MÉTODO PARA MUDAR A VEZ DO JOGADOR
		private void MudaVez() {
			jogador = jogador == 'X' ? 'O' : 'X';
		}


		// MÉTODO PARA LER A ESCOLHA DO USUÁRIO
		private void le_ecolha_usuario() {
			Console.Write($"JODADOR '{jogador}', digite a posição disponível (1 a 9) > ");
			bool conversao = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);

			while (!conversao || !ValidaEscolha(posicaoEscolhida)) {
				Console.Write("OPÇÃO INVÁLIDA! Digite uma posição de 1 a 9 > ");
				conversao = int.TryParse(Console.ReadLine(), out posicaoEscolhida);
			}
			preenche_escolha(posicaoEscolhida);
		}

		private bool ValidaEscolha(int posicaoEscolhida) {
			int indice = posicaoEscolhida - 1;

			if (indice < 0 || indice > 8) {
				return false;
			}

			return posicoes[indice] != 'X' && posicoes[indice] != 'O';
		}

		private void preenche_escolha(int posicaoEscolhida) {
			int indice = posicaoEscolhida - 1;
			posicoes[indice] = jogador;
			quantidadePreenchida++;
		}


        // MÉTODO PARA VERIFICAR VITÓRIA
        private void VerificaFimJogo() {
			if (quantidadePreenchida < 5) {
				return;
			}
	
			else if (vitoria_horizontal() || vitoria_vertical() || vitoria_diagonal()) {
				Console.WriteLine($"FIM DE JOGO: JOGADOR '{jogador}' VENCEU!");
                fimJogo = true;
				return;
            }

			else if (quantidadePreenchida is 9) {
                Console.WriteLine("FIM DE JOGO: DEU VELHA!");
                fimJogo = true;
            }
		}

        private bool vitoria_horizontal() {
			bool vitoriaLinha1 = posicoes[0] == posicoes[1] && posicoes[1] == posicoes[2];
			bool vitoriaLinha2 = posicoes[3] == posicoes[4] && posicoes[4] == posicoes[5];
			bool vitoriaLinha3 = posicoes[6] == posicoes[7] && posicoes[7] == posicoes[8];
            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
        }

        private bool vitoria_vertical() {
            bool vitoriaColuna1 = posicoes[0] == posicoes[3] && posicoes[3] == posicoes[6];
            bool vitoriaColuna2 = posicoes[1] == posicoes[4] && posicoes[4] == posicoes[7];
            bool vitoriaColuna3 = posicoes[2] == posicoes[5] && posicoes[5] == posicoes[8];
            return vitoriaColuna1 || vitoriaColuna2 || vitoriaColuna3;
        }

        private bool vitoria_diagonal() {
            bool vitoriaDiagonal1 = posicoes[0] == posicoes[4] && posicoes[4] == posicoes[8];
            bool vitoriaDiagonal2 = posicoes[2] == posicoes[4] && posicoes[4] == posicoes[6];
            return vitoriaDiagonal1 || vitoriaDiagonal2;
        }


		// MÉTODO INICIAR O JOGO
		public void Iniciar() {
			while (!fimJogo) {
				renderiza_tabela();
				le_ecolha_usuario();
				renderiza_tabela();
				VerificaFimJogo();
				MudaVez();
			}
		}
	}
}