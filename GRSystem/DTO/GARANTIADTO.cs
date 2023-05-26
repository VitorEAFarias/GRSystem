namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class GARANTIADTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="ID_PROCEDIMENTO"></param>
        /// <param name="ID_DETALHES"></param>
        /// <param name="ID_RELATORIOS"></param>
        /// <param name="NUMERO_SERIE"></param>
        /// <param name="CODIGO_ERRO"></param>
        /// <param name="MOMENTO_PROBLEMA"></param>
        /// <param name="CONTADOR_TOTAL"></param>
        /// <param name="FREQUENCIA_FALHA"></param>
        /// <param name="DATA_INSTALACAO"></param>
        /// <param name="DATA_PROBLEMA"></param>
        /// <param name="CONTADOR_INSTALACAO"></param>
        /// <param name="DATA_INSTALACAO_PECA"></param>
        /// <param name="RELATORIO_TECNICO"></param>
        /// <param name="EXEMPLO_COPIA"></param>
        public GARANTIADTO(int ID, int ID_PROCEDIMENTO, int ID_DETALHES, int ID_RELATORIOS, string NUMERO_SERIE, string CODIGO_ERRO, string MOMENTO_PROBLEMA, int CONTADOR_TOTAL,
            string FREQUENCIA_FALHA, DateTime DATA_INSTALACAO, DateTime DATA_PROBLEMA, int CONTADOR_INSTALACAO, DateTime DATA_INSTALACAO_PECA, string RELATORIO_TECNICO,
            byte[] EXEMPLO_COPIA)
        {
            this.ID = ID;
            this.ID_PROCEDIMENTO = ID_PROCEDIMENTO;
            this.ID_DETALHES = ID_DETALHES;
            this.ID_RELATORIOS = ID_RELATORIOS;
            this.NUMERO_SERIE = NUMERO_SERIE;
            this.CODIGO_ERRO = CODIGO_ERRO;
            this.MOMENTO_PROBLEMA = MOMENTO_PROBLEMA;
            this.CONTADOR_TOTAL = CONTADOR_TOTAL;
            this.FREQUENCIA_FALHA = FREQUENCIA_FALHA;
            this.DATA_INSTALACAO = DATA_INSTALACAO;
            this.DATA_PROBLEMA = DATA_PROBLEMA;
            this.CONTADOR_INSTALACAO = CONTADOR_INSTALACAO;
            this.DATA_INSTALACAO_PECA = DATA_INSTALACAO_PECA;
            this.RELATORIO_TECNICO = RELATORIO_TECNICO;
            this.EXEMPLO_COPIA = EXEMPLO_COPIA;
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_PROCEDIMENTO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_DETALHES { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_RELATORIOS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NUMERO_SERIE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CODIGO_ERRO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string MOMENTO_PROBLEMA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CONTADOR_TOTAL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string FREQUENCIA_FALHA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime DATA_INSTALACAO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime DATA_PROBLEMA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CONTADOR_INSTALACAO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime DATA_INSTALACAO_PECA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string RELATORIO_TECNICO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual byte[] EXEMPLO_COPIA { get; set; }
    }
}
