using System.ComponentModel.DataAnnotations.Schema;

namespace FabricaKars.Models
{
	[Table(tbl.FabricaKars)]
	public class ModeloModel
	{
		public int cod_modelo {  get; set; }
		public string nome_modelo {  get; set; }
		public string ind_lista_impedimento { get; set; }

	}
}
