﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.qtdMovimentos = 0;
            this.Tabuleiro = tabuleiro;
        }
    }
}
