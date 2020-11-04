namespace CleanArchitecture.Service.Bootstrap
{
    public class Bootstrap
    {
        private readonly IBootstrapClient _bootstrapClient;

        public Bootstrap(IBootstrapClient bootstrapClient)
        {
            _bootstrapClient = bootstrapClient;
        }

        public void Start()
        {
            _bootstrapClient.Start();
        }
    }
}