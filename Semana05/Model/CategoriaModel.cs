﻿using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana05.Model
{
    public class CategoriaModel
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public bool Insertar(Categoria categoria)
        {
            return (new BCategoria()).Insertar(categoria);
        }
        public bool Actualizar(Categoria categoria)
        {
            return (new BCategoria()).Actualizar(categoria);
        }
        public CategoriaModel()
        {
            var lista = (new BCategoria().Listar(0));
            Categorias = new ObservableCollection<Categoria>(lista);
        }
    }
}
