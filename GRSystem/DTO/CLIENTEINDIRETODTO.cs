using Microsoft.AspNetCore.Server.IIS.Core;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class CLIENTEINDIRETODTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="NOME"></param>
        /// <param name="TELEFONE"></param>
        /// <param name="CELULAR"></param>
        /// <param name="ENDERECO"></param>
        /// <param name="MUNICIPIO"></param>
        /// <param name="UF"></param>
        /// <param name="CEP"></param>
        /// <param name="TIPO_PESSOA"></param>
        /// <param name="CPF_CNPJ"></param>
        /// <param name="INSCRICAO_ESTADUAL"></param>
        public CLIENTEINDIRETODTO(int ID, string NOME, string TELEFONE, string CELULAR, string ENDERECO, string MUNICIPIO, string UF, string CEP, string TIPO_PESSOA,
            string CPF_CNPJ, string INSCRICAO_ESTADUAL)
        {
            this.ID = ID;
            this.NOME = NOME;
            this.TELEFONE = TELEFONE;
            this.CELULAR = CELULAR;
            this.ENDERECO = ENDERECO;
            this.MUNICIPIO = MUNICIPIO;
            this.UF = UF;
            this.CEP = CEP;
            this.TIPO_PESSOA = TIPO_PESSOA;
            this.CPF_CNPJ = CPF_CNPJ;
            this.INSCRICAO_ESTADUAL = INSCRICAO_ESTADUAL;
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NOME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string TELEFONE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CELULAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string ENDERECO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string MUNICIPIO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string UF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CEP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string TIPO_PESSOA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CPF_CNPJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string INSCRICAO_ESTADUAL { get; set; }
    }
}
