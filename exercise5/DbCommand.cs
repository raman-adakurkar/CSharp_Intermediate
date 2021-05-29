namespace exercise5
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new System.Exception("DbConnection cannot be null");

            if (string.IsNullOrWhiteSpace(instruction))
                throw new System.Exception("Instruction Cannot be Null or Empty");

            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            System.Console.WriteLine("Instruction Executed : " + _instruction);
            _dbConnection.Close();
        }
    }
}
