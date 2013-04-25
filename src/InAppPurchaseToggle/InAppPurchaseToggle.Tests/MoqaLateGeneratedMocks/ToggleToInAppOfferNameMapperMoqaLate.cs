using InAppPurchaseToggle;
namespace MoqaLate.Autogenerated
{
public partial class ToggleToInAppOfferNameMapperMoqaLate : IToggleToInAppOfferNameMapper
{


// -------------- Map ------------ 

private string _mapReturnValue;

        private int _mapNumberOfTimesCalled;

        public ToggleBase MapParameter_toggle_LastCalledWith;
        
        public virtual void MapSetReturnValue(string value)
        {
            _mapReturnValue = value;
        }    


        public virtual bool MapWasCalled()
{
   return _mapNumberOfTimesCalled > 0;
}


public virtual bool MapWasCalled(int times)
{
   return _mapNumberOfTimesCalled == times;
}


public virtual int MapTimesCalled()
{
   return _mapNumberOfTimesCalled;
}


public virtual bool MapWasCalledWith(ToggleBase toggle){
return (
toggle.Equals(MapParameter_toggle_LastCalledWith) );
}
 

             public string Map(ToggleBase toggle)
        {
            _mapNumberOfTimesCalled++;            

            MapParameter_toggle_LastCalledWith = toggle;

            return _mapReturnValue;
        }}
}