﻿namespace tabuleiro
{
    public class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString()
        {
            return linha 
                + ", "  
                + coluna;
        }

    }
}
