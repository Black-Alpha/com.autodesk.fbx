//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.11
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FbxSdk {

public class FbxRenamingStrategyBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxRenamingStrategyBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxRenamingStrategyBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxRenamingStrategyBase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxRenamingStrategyBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual bool DecodeScene(FbxScene pScene) {
    bool ret = examplePINVOKE.FbxRenamingStrategyBase_DecodeScene(swigCPtr, FbxScene.getCPtr(pScene));
    return ret;
  }

  public virtual bool EncodeScene(FbxScene pScene) {
    bool ret = examplePINVOKE.FbxRenamingStrategyBase_EncodeScene(swigCPtr, FbxScene.getCPtr(pScene));
    return ret;
  }

  public virtual bool DecodeString(FbxNameHandler pString) {
    bool ret = examplePINVOKE.FbxRenamingStrategyBase_DecodeString(swigCPtr, FbxNameHandler.getCPtr(pString));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool EncodeString(FbxNameHandler pString, bool pIsPropertyName) {
    bool ret = examplePINVOKE.FbxRenamingStrategyBase_EncodeString__SWIG_0(swigCPtr, FbxNameHandler.getCPtr(pString), pIsPropertyName);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool EncodeString(FbxNameHandler pString) {
    bool ret = examplePINVOKE.FbxRenamingStrategyBase_EncodeString__SWIG_1(swigCPtr, FbxNameHandler.getCPtr(pString));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void CleanUp() {
    examplePINVOKE.FbxRenamingStrategyBase_CleanUp(swigCPtr);
  }

  public class NameCell : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal NameCell(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NameCell obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~NameCell() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            examplePINVOKE.delete_FbxRenamingStrategyBase_NameCell(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public NameCell(string pName) : this(examplePINVOKE.new_FbxRenamingStrategyBase_NameCell(pName), true) {
    }
  
    public FbxString mName {
      set {
        examplePINVOKE.FbxRenamingStrategyBase_NameCell_mName_set(swigCPtr, FbxString.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = examplePINVOKE.FbxRenamingStrategyBase_NameCell_mName_get(swigCPtr);
        FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
        return ret;
      } 
    }
  
    public int mInstanceCount {
      set {
        examplePINVOKE.FbxRenamingStrategyBase_NameCell_mInstanceCount_set(swigCPtr, value);
      } 
      get {
        int ret = examplePINVOKE.FbxRenamingStrategyBase_NameCell_mInstanceCount_get(swigCPtr);
        return ret;
      } 
    }
  
  }

  public char mNamespaceSymbol {
    set {
      examplePINVOKE.FbxRenamingStrategyBase_mNamespaceSymbol_set(swigCPtr, value);
    } 
    get {
      char ret = examplePINVOKE.FbxRenamingStrategyBase_mNamespaceSymbol_get(swigCPtr);
      return ret;
    } 
  }

  public FbxCharPtrSet mStringNameArray {
    set {
      examplePINVOKE.FbxRenamingStrategyBase_mStringNameArray_set(swigCPtr, FbxCharPtrSet.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxRenamingStrategyBase_mStringNameArray_get(swigCPtr);
      FbxCharPtrSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCharPtrSet(cPtr, false);
      return ret;
    } 
  }

}

}