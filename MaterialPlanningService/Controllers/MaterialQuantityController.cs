using MaterialPlanningService.Impl;
using MaterialPlanningService.Models.BrickHouse;
using MaterialPlanningService.Models.FrameHouse;
using MaterialPlanningService.Models.WallBlocks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaterialPlanningService.Controllers
{
    /// <summary>
    /// Контроллер
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    
    public class MaterialQuantityController : ControllerBase
    {
        private readonly IMaterialQuantity _materialQuantityCalculator;
        private readonly IRequestValidator _validationService;
        public MaterialQuantityController(IMaterialQuantity materialQuantityCalculator, IRequestValidator requestValidator)
        {
            _materialQuantityCalculator = materialQuantityCalculator;
            _validationService = requestValidator;
        }

        /// <summary>
        /// Получить список видов домов
        /// </summary>
        /// <response code="200">Запрос успешный</response>
        [HttpGet("Available_materials")]
        public IActionResult GetAvailableMaterials()
        {
            var materials = new List<string>
            {
                BuildingMaterial.FrameHouse.ToString(),
                BuildingMaterial.BrickHouse.ToString(),
                BuildingMaterial.WallHouse.ToString()
            };
            if (materials.Count == 0)
            {
                return Ok("Cписок пустой");
            }
            return Ok(materials);
        }

        /// <summary>
        /// Получить количество материала для кирпичного дома 
        /// </summary>
        /// <param name="brickRequest"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/MaterialQuantityController/BrickHouse
        ///     {
        ///             "length": 10,
        ///             "width": 10,
        ///              "height": 10,
        ///             "brickSize": 1,
        ///             "brickUnit": 2,
        ///             "layingType": 2
        ///     }
        /// </remarks>
        /// <response code="200">Запрос успешный</response>
        [HttpPost("BrickHouse")]
        public ActionResult CalculateBricksHouse(BrickRequest brickRequest)
        {
            if (!_validationService.ValidateBrickRequest(brickRequest, out var errorMessage))
            {
                return BadRequest(errorMessage);
            }
            var result = _materialQuantityCalculator.CalculateBrickQuantity(brickRequest);
            var response = new BrickResponse
            {
                BrickSize = brickRequest.BrickSize,
                BrickUnit = brickRequest.BrickUnit,
                LayingType = brickRequest.LayingType,
                TotalBrickCount = result
            };
            return Ok(response);
        }
        /// <summary>
        /// Получить количество материала для кирпичного дома 
        /// </summary>
        /// <param name="brickRequest"></param>
        /// <returns></returns>
        /// /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/MaterialQuantityController/WallHouse
        ///     {
        ///             "length": 10,
        ///              "width": 10,
        ///             "height": 10,
        ///             "glueConsumptionRate": 28,
        ///           "wallThickness": 0.25
        ///     }
        /// </remarks>
        /// <response code="200">Запрос успешный</response>
        [HttpPost("WallHouse")]
        public ActionResult CalculateWall(WallRequest wallRequest)
        {
            if (!_validationService.ValidateWallRequest(wallRequest, out var errorMessage))
            {
                return BadRequest(errorMessage);
            }
            var result = _materialQuantityCalculator.CalculateWallBlockQuantity(wallRequest);
            var response = new WallResponse()
            { 
                TotalBricks = result.TotalBricks,
                TotalGlue = result.TotalGlue,
            };
            return Ok(response);
        }
        /// <summary>
        /// Получить количество материала для кирпичного дома 
        /// </summary>
        /// <param name="brickRequest"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/MaterialQuantityController/FrameHouse
        ///     {
        ///
        ///          "wallLength": 10,
        ///         "wallHeight": 7,
        ///         "postSpacing": 0.25,
        ///          "braceSpacing": 0.25
        ///     }
        /// </remarks>
        /// <response code="200">Запрос успешный</response>
        [HttpPost("FrameHouse")]
        public ActionResult CalculateFrame(FrameRequest frameRequest)
        {
            if (!_validationService.ValidateFrameRequest(frameRequest, out var errorMessage))
            {
                return BadRequest(errorMessage);
            }
            var result = _materialQuantityCalculator.CalculateFrameHouseMaterials(frameRequest);
            var response = new FrameResponse()
            {
                TotalBoards = result.TotalBoards,
                LengthBoards = result.LengthBoards,
                Fasteners = result.Fasteners,
            };
            return Ok(response);
        }


    }
}
