using MaterialPlanningService.Impl;
using MaterialPlanningService.Models.BrickHouse;
using MaterialPlanningService.Models.FrameHouse;
using MaterialPlanningService.Models.WallBlocks;
using Microsoft.OpenApi.Validations;

namespace MaterialPlanningService.Services
{
    /// <summary>
    /// класс для валидации реквестов
    /// </summary>
    public class ValidationService : IRequestValidator
    {
        
        public bool ValidateBrickRequest(BrickRequest request, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (request.Length <= 0)
            {
                errorMessage = "Длина дома должна быть больше 0.";
                return false;
            }
            if (request.Width <= 0)
            {
                errorMessage = "Ширина дома должна быть больше 0.";
                return false;
            }
            if (request.Height <= 0)
            {
                errorMessage = "Высота дома должна быть больше 0.";
                return false;
            }
            if (!Enum.IsDefined(typeof(BrickUnit), request.BrickUnit))
            {
                errorMessage = "Неверное значение для BrickUnit.";
                return false;
            }
            if (!Enum.IsDefined(typeof(BrickSize), request.BrickSize))
            {
                errorMessage = "Неверное значение для BrickSize.";
                return false;
            }
            if (!Enum.IsDefined(typeof(BrickLayingType), request.LayingType))
            {
                errorMessage = "Неверное значение для LayingType.";
                return false;
            }
            return true;
        }
        public bool ValidateFrameRequest(FrameRequest request, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (request.WallLength <= 0)
            {
                errorMessage = "Длина стен должна быть больше 0.";
                return false;
            }
            if (request.WallHeight <= 0)
            {
                errorMessage = "Высота стен должна быть больше 0.";
                return false;
            }
            if (request.PostSpacing <= 0 || request.PostSpacing > request.WallLength)
            {
                errorMessage = "Шаг стоек должен быть больше 0 и меньше длины стены.";
                return false;
            }
            if (request.BraceSpacing <= 0 || request.BraceSpacing > request.WallLength)
            {
                errorMessage = "Шаг распорок должен быть больше 0 и меньше длины стены.";
                return false;
            }
            return true;
        }

        public bool ValidateWallRequest(WallRequest request, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (request.Length <= 0)
            {
                errorMessage = "Длина дома должна быть больше 0.";
                return false;
            }
            if (request.Width <= 0)
            {
                errorMessage = "Ширина дома должна быть больше 0.";
                return false;
            }
            if (request.Height <= 0)
            {
                errorMessage = "Высота дома должна быть больше 0.";
                return false;
            }
            if (request.WallThickness <= 0)
            {
                errorMessage = "Толщина стены должна быть больше 0.";
                return false;
            }
            if (request.ContainerVolume <= 0)
            {
                errorMessage = "Объем контейнера должен быть больше 0.";
                return false;
            }
            if (request.GlueConsumptionRate <= 0)
            {
                errorMessage = "Норма расхода клея должна быть больше 0.";
                return false;
            }
            return true;
        }
    }
}
