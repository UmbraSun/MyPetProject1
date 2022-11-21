using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Models.Interfaces;

namespace BLL.Services
{
    public class CPUService : BaseService<CPU, IServiceResult>, ICPUService
        //where T : class, IServiceResult
    {
        public CPUService(IUnitOfWork uow, 
                          IMapper mapper) : base(uow, mapper)
        { }
    }
}
