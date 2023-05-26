namespace GRSystem.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class CADASTRODTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="ID_CLIENTE"></param>
        /// <param name="CLIENTE_RO"></param>
        /// <param name="SENHA"></param>
        /// <param name="EMAIL"></param>
        public CADASTRODTO(int ID, int ID_CLIENTE, bool CLIENTE_RO, string SENHA, string EMAIL)
        {
            this.ID = ID;
            this.ID_CLIENTE = ID_CLIENTE;
            this.CLIENTE_RO = CLIENTE_RO;
            this.SENHA = SENHA;
            this.EMAIL = EMAIL;
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_CLIENTE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual bool CLIENTE_RO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string SENHA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string EMAIL { get; set; }
    }
}
