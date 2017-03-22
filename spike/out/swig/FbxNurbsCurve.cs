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

public class FbxNurbsCurve : FbxGeometry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxNurbsCurve(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxNurbsCurve_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxNurbsCurve obj) {
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

  public static FbxClassId ClassId {
    set {
      examplePINVOKE.FbxNurbsCurve_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxNurbsCurve_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxNurbsCurve_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxNurbsCurve Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxNurbsCurve_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxNurbsCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbsCurve(cPtr, false);
    return ret;
  }

  public new static FbxNurbsCurve Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxNurbsCurve_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxNurbsCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbsCurve(cPtr, false);
    return ret;
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)examplePINVOKE.FbxNurbsCurve_GetAttributeType(swigCPtr);
    return ret;
  }

  public void InitControlPoints(int pCount, FbxNurbsCurve.EType pVType) {
    examplePINVOKE.FbxNurbsCurve_InitControlPoints__SWIG_0(swigCPtr, pCount, (int)pVType);
  }

  public SWIGTYPE_p_double GetKnotVector() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxNurbsCurve_GetKnotVector(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public int GetKnotCount() {
    int ret = examplePINVOKE.FbxNurbsCurve_GetKnotCount(swigCPtr);
    return ret;
  }

  public void SetOrder(int pOrder) {
    examplePINVOKE.FbxNurbsCurve_SetOrder(swigCPtr, pOrder);
  }

  public int GetOrder() {
    int ret = examplePINVOKE.FbxNurbsCurve_GetOrder(swigCPtr);
    return ret;
  }

  public void SetStep(int pStep) {
    examplePINVOKE.FbxNurbsCurve_SetStep(swigCPtr, pStep);
  }

  public int GetStep() {
    int ret = examplePINVOKE.FbxNurbsCurve_GetStep(swigCPtr);
    return ret;
  }

  public void SetDimension(FbxNurbsCurve.EDimension pDimension) {
    examplePINVOKE.FbxNurbsCurve_SetDimension(swigCPtr, (int)pDimension);
  }

  public FbxNurbsCurve.EDimension GetDimension() {
    FbxNurbsCurve.EDimension ret = (FbxNurbsCurve.EDimension)examplePINVOKE.FbxNurbsCurve_GetDimension(swigCPtr);
    return ret;
  }

  public bool IsRational() {
    bool ret = examplePINVOKE.FbxNurbsCurve_IsRational(swigCPtr);
    return ret;
  }

  public int GetSpanCount() {
    int ret = examplePINVOKE.FbxNurbsCurve_GetSpanCount(swigCPtr);
    return ret;
  }

  public FbxNurbsCurve.EType GetType() {
    FbxNurbsCurve.EType ret = (FbxNurbsCurve.EType)examplePINVOKE.FbxNurbsCurve_GetType(swigCPtr);
    return ret;
  }

  public bool IsPolyline() {
    bool ret = examplePINVOKE.FbxNurbsCurve_IsPolyline(swigCPtr);
    return ret;
  }

  public bool IsBezier() {
    bool ret = examplePINVOKE.FbxNurbsCurve_IsBezier(swigCPtr);
    return ret;
  }

  public int TessellateCurve(SWIGTYPE_p_FbxArrayT_FbxVector4_t pPointArray, int pStep) {
    int ret = examplePINVOKE.FbxNurbsCurve_TessellateCurve__SWIG_0(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxVector4_t.getCPtr(pPointArray), pStep);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int TessellateCurve(SWIGTYPE_p_FbxArrayT_FbxVector4_t pPointArray) {
    int ret = examplePINVOKE.FbxNurbsCurve_TessellateCurve__SWIG_1(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxVector4_t.getCPtr(pPointArray));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLine TessellateCurve(int pStep) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxNurbsCurve_TessellateCurve__SWIG_2(swigCPtr, pStep);
    FbxLine ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLine(cPtr, false);
    return ret;
  }

  public FbxLine TessellateCurve() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxNurbsCurve_TessellateCurve__SWIG_3(swigCPtr);
    FbxLine ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLine(cPtr, false);
    return ret;
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(examplePINVOKE.FbxNurbsCurve_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool FullMultiplicity() {
    bool ret = examplePINVOKE.FbxNurbsCurve_FullMultiplicity(swigCPtr);
    return ret;
  }

  public bool mIsRational {
    set {
      examplePINVOKE.FbxNurbsCurve_mIsRational_set(swigCPtr, value);
    } 
    get {
      bool ret = examplePINVOKE.FbxNurbsCurve_mIsRational_get(swigCPtr);
      return ret;
    } 
  }

  public virtual void SetControlPointAt(FbxVector4 pCtrlPoint, int pIndex) {
    examplePINVOKE.FbxNurbsCurve_SetControlPointAt(swigCPtr, FbxVector4.getCPtr(pCtrlPoint), pIndex);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void InitControlPoints(int pCount) {
    examplePINVOKE.FbxNurbsCurve_InitControlPoints__SWIG_1(swigCPtr, pCount);
  }

  public enum EDimension {
    e2D = 2,
    e3D
  }

  public enum EType {
    eOpen,
    eClosed,
    ePeriodic
  }

  public enum EErrorCode {
    eNurbsCurveTypeUnknown,
    eWeightTooSmall,
    eKnotVectorError,
    eWrongNumberOfControlPoint,
    eErrorCount
  }

}

}