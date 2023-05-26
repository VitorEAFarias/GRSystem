using System.ComponentModel.DataAnnotations;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class LINHASPRODUTOS
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAVE"></param>
        /// <param name="LINHA"></param>
        public LINHASPRODUTOS(int CHAVE, string LINHA)
        {
            this.CHAVE = CHAVE;
            this.LINHA = LINHA;
        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CHAVE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string LINHA { get; private set; }
    }
}
