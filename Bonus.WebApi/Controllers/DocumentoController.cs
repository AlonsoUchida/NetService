﻿using Bonus.BusinessEntities.DTO;
using Bonus.BusinessServices.Interfaces;
using Bonus.WebApi.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bonus.WebApi.Controllers
{
    [AuthorizationRequired]
    public class DocumentoController : ApiController
    {
        #region Private variable.

        private readonly IDocumentoServices _services;

        #endregion

        #region Public Constructor

        public DocumentoController(IDocumentoServices services)
        {
            _services = services;
        }

        #endregion


        /// <summary>
        /// Funncion para obtener los documentos.
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [Route("ObtenerDocumentos")]
        [HttpGet]
        public List<DocumentoEntity> ObtenerDocumentos()
        {
            return _services.ObtenerDocumentos();
        }
    }
}
