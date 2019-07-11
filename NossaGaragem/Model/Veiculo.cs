﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Veiculo
    {
        public int Id;
        public string Modelo;
        public decimal Valor;

        //Propriedades para a coluna doo id_categoria(FK)
        public int IdCategoria;
        /* Objeto da categoria que permitirá acessar as 
         * informações da categoria através do veículo.
         */
        public Categoria Categoria;
    }
}
