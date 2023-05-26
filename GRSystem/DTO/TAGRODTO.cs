using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    [Table("TAG_REIS_OFFICE")]
    public class TAGRODTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAVE"></param>
        /// <param name="CHAVE_PRODUTO"></param>
        /// <param name="NUMERO_SERIE"></param>
        /// <param name="GARANTIA"></param>
        /// <param name="LIMITE_GARANTIA"></param>
        /// <param name="JUSTIFICATIVA_GARANTIA"></param>
        /// <param name="CHAVE_CLIENTE"></param>
        /// <param name="NF"></param>
        /// <param name="DATA_NF"></param>
        /// <param name="FORNECEDOR"></param>
        public TAGRODTO(int CHAVE, int CHAVE_PRODUTO, string NUMERO_SERIE, string GARANTIA, DateTime LIMITE_GARANTIA, string JUSTIFICATIVA_GARANTIA, int CHAVE_CLIENTE,
            string NF, DateTime DATA_NF, string FORNECEDOR)
        {
            this.CHAVE = CHAVE;
            this.CHAVE_PRODUTO = CHAVE_PRODUTO;
            this.NUMERO_SERIE = NUMERO_SERIE;
            this.GARANTIA = GARANTIA;
            this.LIMITE_GARANTIA = LIMITE_GARANTIA;
            this.JUSTIFICATIVA_GARANTIA = JUSTIFICATIVA_GARANTIA;
            this.CHAVE_CLIENTE = CHAVE_CLIENTE;
            this.NF = NF;
            this.DATA_NF = DATA_NF;
            this.FORNECEDOR = FORNECEDOR;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CHAVE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_PRODUTO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NUMERO_SERIE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string GARANTIA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime LIMITE_GARANTIA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string JUSTIFICATIVA_GARANTIA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_CLIENTE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NF { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime DATA_NF { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string FORNECEDOR { get; private set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [Table("TAG_REIS_SERVICE")]
    public class TAGRSDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAVE"></param>
        /// <param name="CHAVE_PRODUTO"></param>
        /// <param name="NUMERO_SERIE"></param>
        /// <param name="GARANTIA"></param>
        /// <param name="LIMITE_GARANTIA"></param>
        /// <param name="JUSTIFICATIVA_GARANTIA"></param>
        /// <param name="CHAVE_CLIENTE"></param>
        /// <param name="NF"></param>
        /// <param name="DATA_NF"></param>
        /// <param name="FORNECEDOR"></param>
        public TAGRSDTO(int CHAVE, int CHAVE_PRODUTO, string NUMERO_SERIE, string GARANTIA, DateTime LIMITE_GARANTIA, string JUSTIFICATIVA_GARANTIA, int CHAVE_CLIENTE,
            string NF, DateTime DATA_NF, string FORNECEDOR)
        {
            this.CHAVE = CHAVE;
            this.CHAVE_PRODUTO = CHAVE_PRODUTO;
            this.NUMERO_SERIE = NUMERO_SERIE;
            this.GARANTIA = GARANTIA;
            this.LIMITE_GARANTIA = LIMITE_GARANTIA;
            this.JUSTIFICATIVA_GARANTIA = JUSTIFICATIVA_GARANTIA;
            this.CHAVE_CLIENTE = CHAVE_CLIENTE;
            this.NF = NF;
            this.DATA_NF = DATA_NF;
            this.FORNECEDOR = FORNECEDOR;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CHAVE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_PRODUTO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NUMERO_SERIE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string GARANTIA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime LIMITE_GARANTIA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string JUSTIFICATIVA_GARANTIA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_CLIENTE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NF { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime DATA_NF { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string FORNECEDOR { get; private set; }
    }
}
