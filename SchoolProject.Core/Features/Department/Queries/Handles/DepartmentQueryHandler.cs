using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Department.Queries.Models;
using SchoolProject.Core.Features.Department.Queries.Results;
using SchoolProject.Core.Resources;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Department.Queries.Handles
{
    public class DepartmentQueryHandler : ResponseHandler,
        IRequestHandler<GetDepartmentByIdQuery, Response<GetDepartmentByIdResponse>>
    {
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IMapper _mapper;
        private readonly IDepartmentService _departmentService;
        #region Fields

        #endregion
        #region constructors
        public DepartmentQueryHandler(IStringLocalizer<SharedResources> stringLocalizer
           , IMapper mapper, IDepartmentService departmentService
            ) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _mapper = mapper;
            _departmentService = departmentService;
        }


        #endregion
        #region handle functions
        #endregion
        public async Task<Response<GetDepartmentByIdResponse>> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            //service get by id include student subject instrctor
            var response = _departmentService.GetDepartmentById(request.Id);
            // check is not exist
            if (response == null) return NotFound<GetDepartmentByIdResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            // mapping
            var result = _mapper.Map<GetDepartmentByIdResponse>(response);
            //return response

            return Success(result);
        }

    }
}
