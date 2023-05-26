using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    [Table("CLIENTES_REIS_OFFICE")]
    public class CLIENTESRODTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CODCLI"></param>
        /// <param name="NOME"></param>
        /// <param name="NOMERED"></param>
        /// <param name="CHAVE_VENDEDOR_MASTER"></param>
        /// <param name="CNPJ"></param>
        public CLIENTESRODTO(int CODCLI, string NOME, string NOMERED, string CHAVE_VENDEDOR_MASTER, string CNPJ)
        {
            this.CODCLI = CODCLI;
            this.NOME = NOME;
            this.NOMERED = NOMERED;
            this.CHAVE_VENDEDOR_MASTER = CHAVE_VENDEDOR_MASTER;
            this.CNPJ = CNPJ;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CODCLI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NOME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NOMERED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CHAVE_VENDEDOR_MASTER { get; set; }        
        /// <summary>
        /// 
        /// </summary>
        public virtual string CNPJ { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    [Table("CLIENTES_REIS_SERVICE")]
    public class CLIENTESRSDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CODCLI"></param>
        /// <param name="NOME"></param>
        /// <param name="NOMERED"></param>
        /// <param name="CHAVE_VENDEDOR_MASTER"></param>
        /// <param name="CNPJ"></param>
        public CLIENTESRSDTO(int CODCLI, string NOME, string NOMERED, string CHAVE_VENDEDOR_MASTER, string CNPJ)
        {
            this.CODCLI = CODCLI;
            this.NOME = NOME;
            this.NOMERED = NOMERED;
            this.CHAVE_VENDEDOR_MASTER = CHAVE_VENDEDOR_MASTER;
            this.CNPJ = CNPJ;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CODCLI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NOME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NOMERED { get; set; }
        /// <summary>
        /// 
        /// </summary>        
        public virtual string CHAVE_VENDEDOR_MASTER { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CNPJ { get; set; }
    }
}
