namespace WebApi.Services
{
    public class ThirdService
    {
        private readonly FirstService _firstService;
        private readonly SecondService _secondService;
        private readonly SecondService _secondServiceNewInstance;

        public ThirdService(
            FirstService firstService,
            SecondService secondService,
            SecondService secondServiceNewInstance)
        {
            _firstService = firstService;
            _secondService = secondService;
            _secondServiceNewInstance = secondServiceNewInstance;
        }

        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid FirstServiceId => _firstService.Id;

        public Guid SecondServiceId => _secondService.Id;

        public Guid SecondServiceNewInstanceId => _secondServiceNewInstance.Id;
    }
}
