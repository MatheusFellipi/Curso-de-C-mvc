using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cusrso_mvc.Models
{
    public class ProdutosModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public CategoriasModel CategoryModel { get; set; }
    }
}
