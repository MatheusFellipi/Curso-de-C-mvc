using System.Collections.Generic;

namespace cusrso_mvc.Models
{
    public class CategoriasModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public List<ProdutosModel> Produtos { get; set; }
    }
}
