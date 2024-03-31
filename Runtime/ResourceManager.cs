using System.Collections.Generic; 
using Cysharp.Threading.Tasks; 
using Framework.Intializer;
using LD.Singleton;
using UnityEngine;
using UnityEngine.AddressableAssets; 
  
 
public class ResourceManager : Singleton<ResourceManager>, IInitializeAble
{
    public IInitializeAble.eTiming Timing { get => IInitializeAble.eTiming.After;}
    public bool NonAwait => false;
    public int Order => int.MinValue;
    
    public string[] AllowScenes => null; 
    
    public async UniTask Initialize()
    {
        Debug.Log("Called.");
    } 

    /// <summary>
    /// 따로 메모리를 관리 할 필요 없음.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns> 
    public async UniTask<GameObject> InstantiateAsync(string path)
    { 
        return await Addressables.InstantiateAsync(path, trackHandle:true);
    }   
      
}
