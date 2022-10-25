using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Models.Interfaces;

namespace BLL.Services
{
    public class CPUService : BaseService<CPU, IServiceResult>, ICPUService
    {
        public CPUService(IUnitOfWork uow, 
                          IMapper mapper, 
                          IRepository<CPU> repository) : base(uow, mapper, repository)
        { }
    }
}
