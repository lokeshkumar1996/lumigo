using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;


// Deriving the Purchaser class from IStoreListener enables it to receive messages from Unity Purchasing.
public class Purchaser : MonoBehaviour, IStoreListener
{

    //fordis game alone save and load
    public LevelDiamonddata l;
    public ReferalPurchasedata p;
    //
    private static IStoreController m_StoreController;          // The Unity Purchasing system.
    private static IExtensionProvider m_StoreExtensionProvider; // The store-specific Purchasing subsystems.

    
    public static string PRODUCT_DIAMOND1 =    "diamonds1";  //500 diamonds
    public static string PRODUCT_DIAMOND2 =    "diamonds2";    //2000 diamonds
    public static string PRODUCT_DIAMOND3 =    "diamonds3";  // 5000 diamonds

    public static string PRODUCT_UNLOCK   = "unlocklevels";
    public static string PRODUCT_NO_ADS =  "noads"; 

   
   
    private void Start()
    {
        // If we haven't set up the Unity Purchasing reference
        if (m_StoreController == null)
        {
            // Begin to configure our connection to Purchasing
            InitializePurchasing();
        }
        DontDestroyOnLoad(this);
    }

    public void InitializePurchasing() 
    {
        // If we have already connected to Purchasing ...
        if (IsInitialized())
        {
            // ... we are done here.
            return;
        }

        
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

       
        builder.AddProduct(PRODUCT_DIAMOND1, ProductType.Consumable);
        builder.AddProduct(PRODUCT_DIAMOND2, ProductType.Consumable);
        builder.AddProduct(PRODUCT_DIAMOND3, ProductType.Consumable);
        builder.AddProduct(PRODUCT_UNLOCK, ProductType.Consumable);       
        builder.AddProduct(PRODUCT_NO_ADS, ProductType.NonConsumable);
        
        
        // Kick off the remainder of the set-up with an asynchrounous call, passing the configuration 
        // and this class' instance. Expect a response either in OnInitialized or OnInitializeFailed.
        UnityPurchasing.Initialize(this, builder);
    }


    private bool IsInitialized()
    {
        // Only say we are initialized if both the Purchasing references are set.
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }


    public void Buydiamonds1()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_DIAMOND1);
    }

       public void Buydiamonds2()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_DIAMOND2);
    }

       public void Buydiamonds3()
    {
        // Buy the consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_DIAMOND3);
    }



    public void Buyunlock()
    {
        // Buy the non-consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_UNLOCK);
    }

     public void Buynoads()
    {
        // Buy the non-consumable product using its general identifier. Expect a response either 
        // through ProcessPurchase or OnPurchaseFailed asynchronously.
        BuyProductID(PRODUCT_NO_ADS);
    }

    

    void BuyProductID(string productId)
    {
        // If Purchasing has been initialized ...
        if (IsInitialized())
        {
            // ... look up the Product reference with the general product identifier and the Purchasing 
            // system's products collection.
            Product product = m_StoreController.products.WithID(productId);

            // If the look up found a product for this device's store and that product is ready to be sold ... 
            if (product != null && product.availableToPurchase)
            {
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                // ... buy the product. Expect a response either through ProcessPurchase or OnPurchaseFailed 
                // asynchronously.
                m_StoreController.InitiatePurchase(product);
            }
            // Otherwise ...
            else
            {
                // ... report the product look-up failure situation  
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        // Otherwise ...
        else
        {
            // ... report the fact Purchasing has not succeeded initializing yet. Consider waiting longer or 
            // retrying initiailization.
            Debug.Log("BuyProductID FAIL. Not initialized.");
        }
    }

    

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        // Purchasing has succeeded initializing. Collect our Purchasing references.
        Debug.Log("OnInitialized: PASS");

        // Overall Purchasing system, configured with products for this application.
        m_StoreController = controller;
        // Store specific subsystem, for accessing device-specific store features.
        m_StoreExtensionProvider = extensions;
    }


    public void OnInitializeFailed(InitializationFailureReason error)
    {
        // Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }


    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args) 
    {
        
        if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_DIAMOND1, StringComparison.Ordinal))
        {
            //Debug.Log("bought diamonds1");
            
            /*int totaldiamonds = PlayerPrefs.GetInt("diamonds");
            totaldiamonds  = totaldiamonds + 500;
            PlayerPrefs.SetInt("diamonds",totaldiamonds);
            FindObjectOfType<AudioManager>().Play("purchased");*/

         
            int totaldiamonds = AudioManager.instance.diamonds;
            totaldiamonds  = totaldiamonds + 500;
            l.diamonds = totaldiamonds;
            AudioManager.instance.diamonds = l.diamonds;
            l.leveldone = AudioManager.instance.leveldone;
            l.savedata();
            FindObjectOfType<AudioManager>().Play("purchased");

            

            
            // 
          
        }

        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_DIAMOND2, StringComparison.Ordinal))
        {
            //Debug.Log("bought diamonds2");
          //  l.loaddata();
            int totaldiamonds = AudioManager.instance.diamonds;
            totaldiamonds  = totaldiamonds + 2000;
            l.diamonds = totaldiamonds;
            AudioManager.instance.diamonds = l.diamonds;
            l.leveldone = AudioManager.instance.leveldone;
            l.savedata();
            FindObjectOfType<AudioManager>().Play("purchased");
            // 
          
        }
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_DIAMOND3, StringComparison.Ordinal))
        {
            //Debug.Log("bought diamonds3");
          //  l.loaddata();
            int totaldiamonds = AudioManager.instance.diamonds;
            totaldiamonds  = totaldiamonds + 5000;
            l.diamonds = totaldiamonds;
            AudioManager.instance.diamonds = l.diamonds;
            l.leveldone = AudioManager.instance.leveldone;
            l.savedata();
            FindObjectOfType<AudioManager>().Play("purchased");
            // 
          
        }
        
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_UNLOCK, StringComparison.Ordinal))
        {
           //Debug.Log("bought unlock");
           /*PlayerPrefs.SetInt("ReferalClaimed", 1); 
           PlayerPrefs.SetInt("noads", 1);*/
           FindObjectOfType<AudioManager>().Play("purchased");
            p.noads = 1;
            p.ReferalClaimed = 1;
            p.otherreferalclaimed = 1;
            AudioManager.instance.noads = p.noads;
            AudioManager.instance.ReferalClaimed = p.ReferalClaimed;
            AudioManager.instance.otherreferalclaimed = p.otherreferalclaimed;
            p.savedata();
            
        }
      
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_NO_ADS, StringComparison.Ordinal))
        {
          // Debug.Log("bought noads");
          // PlayerPrefs.SetInt("noads", 1); 

           
        }
        // Or ... an unknown product has been purchased by this user. Fill in additional products here....
        else 
        {
            Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
        }

       
        return PurchaseProcessingResult.Complete;
    }


    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        // A product purchase attempt did not succeed. Check failureReason for more detail. Consider sharing 
        // this reason with the user to guide their troubleshooting actions.
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }
}
