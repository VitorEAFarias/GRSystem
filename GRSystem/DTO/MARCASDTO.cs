using System.ComponentModel.DataAnnotations;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class MARCASDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAVE"></param>
        /// <param name="MARCA"></param>
        public MARCASDTO(int CHAVE, string MARCA)
        {
            this.CHAVE = CHAVE;
            this.MARCA = MARCA;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CHAVE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string MARCA { get; private set; }
    }
}
