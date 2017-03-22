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

public class FbxPropertyInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxPropertyInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPropertyInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FbxPropertyInfo Create(string pName, FbxPropertyPage pTypeInfo) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxPropertyInfo_Create__SWIG_0(pName, FbxPropertyPage.getCPtr(pTypeInfo));
    FbxPropertyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyInfo(cPtr, false);
    return ret;
  }

  public static FbxPropertyInfo Create(string pName, EFbxType pType) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxPropertyInfo_Create__SWIG_1(pName, (int)pType);
    FbxPropertyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyInfo(cPtr, false);
    return ret;
  }

  public static FbxPropertyInfo Create(string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxPropertyInfo_Create__SWIG_2(pName);
    FbxPropertyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyInfo(cPtr, false);
    return ret;
  }

  public void Destroy() {
    examplePINVOKE.FbxPropertyInfo_Destroy(swigCPtr);
  }

  public FbxPropertyInfo Clone(FbxPropertyPage arg0) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxPropertyInfo_Clone(swigCPtr, FbxPropertyPage.getCPtr(arg0));
    FbxPropertyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyInfo(cPtr, false);
    return ret;
  }

  public void IncRef() {
    examplePINVOKE.FbxPropertyInfo_IncRef(swigCPtr);
  }

  public void DecRef() {
    examplePINVOKE.FbxPropertyInfo_DecRef(swigCPtr);
  }

  public int GetRef() {
    int ret = examplePINVOKE.FbxPropertyInfo_GetRef(swigCPtr);
    return ret;
  }

  public FbxStringSymbol GetName() {
    FbxStringSymbol ret = new FbxStringSymbol(examplePINVOKE.FbxPropertyInfo_GetName(swigCPtr), true);
    return ret;
  }

  public EFbxType GetType() {
    EFbxType ret = (EFbxType)examplePINVOKE.FbxPropertyInfo_GetType(swigCPtr);
    return ret;
  }

  public FbxPropertyPage GetTypeInfo() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxPropertyInfo_GetTypeInfo(swigCPtr);
    FbxPropertyPage ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyPage(cPtr, false);
    return ret;
  }

  public void SetLabel(string pLabel) {
    examplePINVOKE.FbxPropertyInfo_SetLabel(swigCPtr, pLabel);
  }

  public string GetLabel() {
    string ret = examplePINVOKE.FbxPropertyInfo_GetLabel(swigCPtr);
    return ret;
  }

  public void SetUserTag(int pUserTag) {
    examplePINVOKE.FbxPropertyInfo_SetUserTag(swigCPtr, pUserTag);
  }

  public int GetUserTag() {
    int ret = examplePINVOKE.FbxPropertyInfo_GetUserTag(swigCPtr);
    return ret;
  }

  public void SetUserData(SWIGTYPE_p_void pUserData) {
    examplePINVOKE.FbxPropertyInfo_SetUserData(swigCPtr, SWIGTYPE_p_void.getCPtr(pUserData));
  }

  public SWIGTYPE_p_void GetUserData() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxPropertyInfo_GetUserData(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public int AddEnumValue(string pStringValue) {
    int ret = examplePINVOKE.FbxPropertyInfo_AddEnumValue(swigCPtr, pStringValue);
    return ret;
  }

  public void InsertEnumValue(int pIndex, string pStringValue) {
    examplePINVOKE.FbxPropertyInfo_InsertEnumValue(swigCPtr, pIndex, pStringValue);
  }

  public int GetEnumCount() {
    int ret = examplePINVOKE.FbxPropertyInfo_GetEnumCount(swigCPtr);
    return ret;
  }

  public void SetEnumValue(int pIndex, string pStringValue) {
    examplePINVOKE.FbxPropertyInfo_SetEnumValue(swigCPtr, pIndex, pStringValue);
  }

  public void RemoveEnumValue(int pIndex) {
    examplePINVOKE.FbxPropertyInfo_RemoveEnumValue(swigCPtr, pIndex);
  }

  public string GetEnumValue(int pIndex) {
    string ret = examplePINVOKE.FbxPropertyInfo_GetEnumValue(swigCPtr, pIndex);
    return ret;
  }

  public bool HasMinMax(FbxPropertyInfo.EValueIndex pId) {
    bool ret = examplePINVOKE.FbxPropertyInfo_HasMinMax(swigCPtr, (int)pId);
    return ret;
  }

  public bool GetMinMax(FbxPropertyInfo.EValueIndex pId, SWIGTYPE_p_void pValue, EFbxType pValueType) {
    bool ret = examplePINVOKE.FbxPropertyInfo_GetMinMax(swigCPtr, (int)pId, SWIGTYPE_p_void.getCPtr(pValue), (int)pValueType);
    return ret;
  }

  public bool SetMinMax(FbxPropertyInfo.EValueIndex pId, SWIGTYPE_p_void pValue, EFbxType pValueType) {
    bool ret = examplePINVOKE.FbxPropertyInfo_SetMinMax(swigCPtr, (int)pId, SWIGTYPE_p_void.getCPtr(pValue), (int)pValueType);
    return ret;
  }

  public enum EValueIndex {
    eValueMin,
    eValueSoftMin,
    eValueMax,
    eValueSoftMax,
    eValueCount
  }

}

}