//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ufal.UDPipe {

public class MultiwordToken : Token {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MultiwordToken(global::System.IntPtr cPtr, bool cMemoryOwn) : base(udpipe_csharpPINVOKE.MultiwordToken_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MultiwordToken obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MultiwordToken() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          udpipe_csharpPINVOKE.delete_MultiwordToken(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public int idFirst {
    set {
      udpipe_csharpPINVOKE.MultiwordToken_idFirst_set(swigCPtr, value);
    } 
    get {
      int ret = udpipe_csharpPINVOKE.MultiwordToken_idFirst_get(swigCPtr);
      return ret;
    } 
  }

  public int idLast {
    set {
      udpipe_csharpPINVOKE.MultiwordToken_idLast_set(swigCPtr, value);
    } 
    get {
      int ret = udpipe_csharpPINVOKE.MultiwordToken_idLast_get(swigCPtr);
      return ret;
    } 
  }

  public MultiwordToken(int id_first, int id_last, string form, string misc) : this(udpipe_csharpPINVOKE.new_MultiwordToken__SWIG_0(id_first, id_last, form, misc), true) {
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public MultiwordToken(int id_first, int id_last, string form) : this(udpipe_csharpPINVOKE.new_MultiwordToken__SWIG_1(id_first, id_last, form), true) {
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public MultiwordToken(int id_first, int id_last) : this(udpipe_csharpPINVOKE.new_MultiwordToken__SWIG_2(id_first, id_last), true) {
  }

  public MultiwordToken(int id_first) : this(udpipe_csharpPINVOKE.new_MultiwordToken__SWIG_3(id_first), true) {
  }

  public MultiwordToken() : this(udpipe_csharpPINVOKE.new_MultiwordToken__SWIG_4(), true) {
  }

}

}
