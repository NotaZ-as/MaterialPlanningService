using MaterialPlanningService.Models.BrickHouse;
using MaterialPlanningService.Models.FrameHouse;
using MaterialPlanningService.Models.WallBlocks;

namespace MaterialPlanningService.Impl
{
    public interface IRequestValidator
    {
        bool ValidateBrickRequest(BrickRequest request, out string errorMessage);
        bool ValidateWallRequest(WallRequest request, out string errorMessage);
        bool ValidateFrameRequest(FrameRequest request, out string errorMessage);
    }

}
