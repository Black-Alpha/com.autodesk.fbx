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

public class FbxQueryOperatorUnary : FbxQuery {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxQueryOperatorUnary(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxQueryOperatorUnary_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxQueryOperatorUnary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxQueryOperatorUnary Create(FbxQuery pA) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxQueryOperatorUnary_Create(FbxQuery.getCPtr(pA));
    FbxQueryOperatorUnary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxQueryOperatorUnary(cPtr, false);
    return ret;
  }

  public override int GetUniqueId() {
    int ret = examplePINVOKE.FbxQueryOperatorUnary_GetUniqueId(swigCPtr);
    return ret;
  }

  public override bool IsValid(FbxProperty pProperty) {
    bool ret = examplePINVOKE.FbxQueryOperatorUnary_IsValid(swigCPtr, FbxProperty.getCPtr(pProperty));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsEqual(FbxQuery pOtherQuery) {
    bool ret = examplePINVOKE.FbxQueryOperatorUnary_IsEqual(swigCPtr, FbxQuery.getCPtr(pOtherQuery));
    return ret;
  }

}

}