using System;

namespace InAppPurchaseToggle
{
    /// <summary>
    /// Inherit from this if you need to create a "repeat" purchase.
    /// <remarks>
    /// 
    /// A repeat purchase is typically used to purchase multiple instances
    /// of something. For example a slot machine that you can keep purchasing
    /// coins for.
    /// 
    /// To create a repeat purchase, inherit from this and override the <see cref="SetAvailableStoreInstances"/> 
    /// method to return the total number of instances of this purchase.
    /// 
    /// </remarks>
    /// </summary>
    public abstract class RepeatPurchaseToggleBase
    {
        private readonly int _availableStoreInstances;

        protected RepeatPurchaseToggleBase()
        {
            StoreGateway = new RealStoreGateway();
            StoreInAppOfferNameMapper = new SingleToggleToStoreInAppOfferNameMapper();

// ReSharper disable DoNotCallOverridableMethodsInConstructor
            _availableStoreInstances = SetAvailableStoreInstances();
            NameInstanceFormatter = SetNameInstanceFormatter();
// ReSharper restore DoNotCallOverridableMethodsInConstructor

            if (_availableStoreInstances < 1)
            {
                throw new InvalidOperationException(
                    "A repeat toggle must have more than zero instances. Ensure you have correctly implemented the SetAvailableStoreInstances method in your concrete toggle.");
            }

            if (NameInstanceFormatter == null)
            {
                throw new NullReferenceException("A custom formatter cannot be null.");
            }
        }

        /// <summary>
        /// The Store gateway to use
        /// </summary>
        public IStoreGateway StoreGateway { get; set; }

        /// <summary>
        /// The mapper that uses the concrete toggle type and maps it the base string that
        /// later has the instance number appended to it
        /// </summary>
        public ISingleToggleToStoreInAppOfferNameMapper StoreInAppOfferNameMapper { get; set; }

        /// <summary>
        /// The formatter that take a base toggle name and adds an instance number to it
        /// </summary>
        public IRepeatPurchaseToggleNameInstanceFormatter NameInstanceFormatter { get; set; }

        /// <summary>
        /// Total instances that are available in the store (as set in derived class by overriding <see cref="SetAvailableStoreInstances"/>
        /// </summary>
        public int AvailableStoreInstances
        {
            get { return _availableStoreInstances; }
        }

        /// <summary>
        /// Sets the default name-instance number formatter
        /// </summary>
        /// <remarks>
        /// Override in derived class to set a non-default formatter
        /// </remarks>
        /// <returns>
        /// The <see cref="IRepeatPurchaseToggleNameInstanceFormatter"/> to use when formatting the final
        /// in app offer name as passed to the Windows Store
        /// </returns>
        protected virtual IRepeatPurchaseToggleNameInstanceFormatter SetNameInstanceFormatter()
        {
            return new NameUnderscoreNumberFormatter();
        }

        /// <summary>
        /// Queries if a specific instance of the purchase has been made
        /// </summary>
        /// <param name="instance">the instance number of the repeated toggle</param>
        /// <returns>True if the user has purchased that instance, otherwise false.</returns>
        public bool IsInstancePurchased(int instance)
        {
            var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(instance);

            return StoreGateway.IsPurchased(nameAndInstanceNumber);
        }

        /// <summary>
        /// Enumerates all the available repeats to see how many the user has purchased
        /// </summary>
        /// <returns>The number of instances purchased by the user</returns>
        public int GetTotalPurchased()
        {
            int total = 0;

            for (var i = 1; i <= _availableStoreInstances; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (StoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    total++;
                }
            }
            return total;
        }

        private string CreateStoreInAppOfferNameWithInstanceNumber(int instance)
        {
            var baseInAppOfferName = StoreInAppOfferNameMapper.Map(GetType());

            var nameAndInstanceNumber = NameInstanceFormatter.Format(baseInAppOfferName, instance);

            return nameAndInstanceNumber;
        }

        protected abstract int SetAvailableStoreInstances();

        /// <summary>
        /// Enumerates all the available repeats to see the user has purchased them all
        /// </summary>
        /// <returns>True if all instances have been purchased by the user, else false</returns>
        public bool IsAllPurchased()
        {
            for (var i = 1; i <= _availableStoreInstances; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (! StoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Enumerates all the available repeats to find the next lowest instance that has yet to be purchased
        /// </summary>
        /// <returns>The instance number of the next lowest unpurchased instance</returns>
        public int GetNextLowestUnpurchasedInstance()
        {
            for (var i = 0; i < _availableStoreInstances; i++)
            {
                var nameAndInstanceNumber = CreateStoreInAppOfferNameWithInstanceNumber(i);

                if (!StoreGateway.IsPurchased(nameAndInstanceNumber))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}