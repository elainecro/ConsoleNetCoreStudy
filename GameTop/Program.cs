﻿using System;
using GameTop.lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador("Ronaldo"), new Jogador2());
            jogo.IniciarJogo();
        }
    }
}
