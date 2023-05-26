namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class DETALHESDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="SITUACAO_PROBLEMA"></param>
        /// <param name="CAUSA_FALHA"></param>
        /// <param name="REPARO"></param>
        /// <param name="COMENTARIO"></param>
        public DETALHESDTO(int ID, string SITUACAO_PROBLEMA, string CAUSA_FALHA, string REPARO, string COMENTARIO)
        {
            this.ID = ID;
            this.SITUACAO_PROBLEMA = SITUACAO_PROBLEMA;
            this.CAUSA_FALHA = CAUSA_FALHA;
            this.REPARO = REPARO;
            this.COMENTARIO = COMENTARIO;
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string SITUACAO_PROBLEMA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CAUSA_FALHA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string REPARO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string COMENTARIO { get; set; }
    }
}
