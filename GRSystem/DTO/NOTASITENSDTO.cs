using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class NOTASITENSDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAVE"></param>
        /// <param name="CHAVE_NOTA"></param>
        /// <param name="CHAVE_PRODUTO"></param>
        /// <param name="CODIGO_PRODUTO"></param>
        /// <param name="QUANTIDADE"></param>
        /// <param name="DESCRICAO_PRODUTO"></param>
        /// <param name="PRECO_FATURADO"></param>
        /// <param name="PESO_LIQUIDO"></param>
        public NOTASITENSDTO(int CHAVE, int CHAVE_NOTA, int CHAVE_PRODUTO, int CODIGO_PRODUTO, int QUANTIDADE, string DESCRICAO_PRODUTO, float PRECO_FATURADO, int PESO_LIQUIDO)
        {
            this.CHAVE = CHAVE;
            this.CHAVE_NOTA = CHAVE_NOTA;
            this.CHAVE_PRODUTO = CHAVE_PRODUTO;
            this.CODIGO_PRODUTO = CODIGO_PRODUTO;
            this.QUANTIDADE = QUANTIDADE;
            this.DESCRICAO_PRODUTO = DESCRICAO_PRODUTO;
            this.PRECO_FATURADO = PRECO_FATURADO;
            this.PESO_LIQUIDO = PESO_LIQUIDO;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CHAVE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_NOTA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_PRODUTO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CODIGO_PRODUTO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int QUANTIDADE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string DESCRICAO_PRODUTO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual float PRECO_FATURADO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int PESO_LIQUIDO { get; private set; }
    }
}
