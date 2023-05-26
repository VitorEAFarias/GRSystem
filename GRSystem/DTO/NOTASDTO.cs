using System.ComponentModel.DataAnnotations;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class NOTASDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAVE"></param>
        /// <param name="NF"></param>
        /// <param name="CHAVE_CLIENTE"></param>
        /// <param name="CHAVE_VENDEDOR"></param>
        /// <param name="DESTINO"></param>
        /// <param name="DATA_EMISSAO"></param>
        public NOTASDTO(int CHAVE, string NF, int CHAVE_CLIENTE, int CHAVE_VENDEDOR, string DESTINO, DateTime DATA_EMISSAO)
        {
            this.CHAVE = CHAVE;
            this.NF = NF;
            this.CHAVE_CLIENTE = CHAVE_CLIENTE;
            this.CHAVE_VENDEDOR = CHAVE_VENDEDOR;
            this.DESTINO = DESTINO;
            this.DATA_EMISSAO = DATA_EMISSAO;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CHAVE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NF{ get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_CLIENTE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_VENDEDOR { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string DESTINO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime DATA_EMISSAO { get; private set; }
    }
}
