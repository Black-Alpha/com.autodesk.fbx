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

public class FbxStream : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxStream(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxStream obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxStream() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxStream(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual FbxStream.EState GetState() {
    FbxStream.EState ret = (FbxStream.EState)examplePINVOKE.FbxStream_GetState(swigCPtr);
    return ret;
  }

  public virtual bool Open(SWIGTYPE_p_void pStreamData) {
    bool ret = examplePINVOKE.FbxStream_Open(swigCPtr, SWIGTYPE_p_void.getCPtr(pStreamData));
    return ret;
  }

  public virtual bool Close() {
    bool ret = examplePINVOKE.FbxStream_Close(swigCPtr);
    return ret;
  }

  public virtual bool Flush() {
    bool ret = examplePINVOKE.FbxStream_Flush(swigCPtr);
    return ret;
  }

  public virtual int Write(SWIGTYPE_p_void arg0, int arg1) {
    int ret = examplePINVOKE.FbxStream_Write__SWIG_0(swigCPtr, SWIGTYPE_p_void.getCPtr(arg0), arg1);
    return ret;
  }

  public virtual int Read(SWIGTYPE_p_void arg0, int arg1) {
    int ret = examplePINVOKE.FbxStream_Read__SWIG_0(swigCPtr, SWIGTYPE_p_void.getCPtr(arg0), arg1);
    return ret;
  }

  public virtual string ReadString(string pBuffer, int pMaxSize, bool pStopAtFirstWhiteSpace) {
    string ret = examplePINVOKE.FbxStream_ReadString__SWIG_0(swigCPtr, pBuffer, pMaxSize, pStopAtFirstWhiteSpace);
    return ret;
  }

  public virtual string ReadString(string pBuffer, int pMaxSize) {
    string ret = examplePINVOKE.FbxStream_ReadString__SWIG_1(swigCPtr, pBuffer, pMaxSize);
    return ret;
  }

  public virtual int GetReaderID() {
    int ret = examplePINVOKE.FbxStream_GetReaderID(swigCPtr);
    return ret;
  }

  public virtual int GetWriterID() {
    int ret = examplePINVOKE.FbxStream_GetWriterID(swigCPtr);
    return ret;
  }

  public virtual void Seek(long pOffset, FbxFile.ESeekPos pSeekPos) {
    examplePINVOKE.FbxStream_Seek(swigCPtr, pOffset, (int)pSeekPos);
  }

  public virtual int GetPosition() {
    int ret = examplePINVOKE.FbxStream_GetPosition(swigCPtr);
    return ret;
  }

  public virtual void SetPosition(int pPosition) {
    examplePINVOKE.FbxStream_SetPosition(swigCPtr, pPosition);
  }

  public virtual int GetError() {
    int ret = examplePINVOKE.FbxStream_GetError(swigCPtr);
    return ret;
  }

  public virtual void ClearError() {
    examplePINVOKE.FbxStream_ClearError(swigCPtr);
  }

  public int Write(string pData, int pSize) {
    int ret = examplePINVOKE.FbxStream_Write__SWIG_1(swigCPtr, pData, pSize);
    return ret;
  }

  public int Write(SWIGTYPE_p_int pData, int pSize) {
    int ret = examplePINVOKE.FbxStream_Write__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(pData), pSize);
    return ret;
  }

  public int Read(string pData, int pSize) {
    int ret = examplePINVOKE.FbxStream_Read__SWIG_1(swigCPtr, pData, pSize);
    return ret;
  }

  public int Read(SWIGTYPE_p_int pData, int pSize) {
    int ret = examplePINVOKE.FbxStream_Read__SWIG_2(swigCPtr, SWIGTYPE_p_int.getCPtr(pData), pSize);
    return ret;
  }

  public enum EState {
    eClosed,
    eOpen,
    eEmpty
  }

}

}