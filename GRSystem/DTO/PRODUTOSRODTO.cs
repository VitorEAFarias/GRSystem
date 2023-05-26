using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    [Table("PRODUTOS_REIS_OFFICE")]
    public class PRODUTOSRODTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CPROD"></param>
        /// <param name="CODIGO"></param>
        /// <param name="CODIGO_INTERNO"></param>
        /// <param name="CHAVE_LINHA"></param>
        /// <param name="CHAVE_GRUPO"></param>
        /// <param name="CHAVE_MARCA"></param>
        public PRODUTOSRODTO(int CPROD, string CODIGO, int CODIGO_INTERNO, int CHAVE_LINHA, int CHAVE_GRUPO, int CHAVE_MARCA)
        {
            this.CPROD = CPROD;
            this.CODIGO = CODIGO;
            this.CODIGO_INTERNO = CODIGO_INTERNO;
            this.CHAVE_LINHA = CHAVE_LINHA;
            this.CHAVE_GRUPO = CHAVE_GRUPO;
            this.CHAVE_MARCA = CHAVE_MARCA;
        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CPROD { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CODIGO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CODIGO_INTERNO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_LINHA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_GRUPO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_MARCA { get; private set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [Table("PRODUTOS_REIS_SERVICE")]
    public class PRODUTOSRSDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CPROD"></param>
        /// <param name="CODIGO"></param>
        /// <param name="CODIGO_INTERNO"></param>
        /// <param name="CHAVE_LINHA"></param>
        /// <param name="CHAVE_GRUPO"></param>
        /// <param name="CHAVE_MARCA"></param>
        public PRODUTOSRSDTO(int CPROD, string CODIGO, int CODIGO_INTERNO, int CHAVE_LINHA, int CHAVE_GRUPO, int CHAVE_MARCA)
        {
            this.CPROD = CPROD;
            this.CODIGO = CODIGO;
            this.CODIGO_INTERNO = CODIGO_INTERNO;
            this.CHAVE_LINHA = CHAVE_LINHA;
            this.CHAVE_GRUPO = CHAVE_GRUPO;
            this.CHAVE_MARCA = CHAVE_MARCA;
        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CPROD { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CODIGO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CODIGO_INTERNO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_LINHA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_GRUPO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_MARCA { get; private set; }
    }
}
