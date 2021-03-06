//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SharpFace
{

    public class CLNF : global::System.IDisposable
    {
        public global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal CLNF(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CLNF obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~CLNF()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock(this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        LandmarkDetectorPINVOKE.delete_CLNF(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SWIGTYPE_p_PDM pdm
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_pdm_set(swigCPtr, SWIGTYPE_p_PDM.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_PDM ret = new SWIGTYPE_p_PDM(LandmarkDetectorPINVOKE.CLNF_pdm_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public SWIGTYPE_p_Patch_experts patch_experts
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_patch_experts_set(swigCPtr, SWIGTYPE_p_Patch_experts.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_Patch_experts ret = new SWIGTYPE_p_Patch_experts(LandmarkDetectorPINVOKE.CLNF_patch_experts_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public SWIGTYPE_p_cv__Mat_T_double_t params_local
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_params_local_set(swigCPtr, SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Mat_T_double_t ret = new SWIGTYPE_p_cv__Mat_T_double_t(LandmarkDetectorPINVOKE.CLNF_params_local_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public SWIGTYPE_p_cv__Vec6d params_global
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_params_global_set(swigCPtr, SWIGTYPE_p_cv__Vec6d.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Vec6d ret = new SWIGTYPE_p_cv__Vec6d(LandmarkDetectorPINVOKE.CLNF_params_global_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public SWIGTYPE_p_std__vectorT_LandmarkDetector__CLNF_t hierarchical_models
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_hierarchical_models_set(swigCPtr, SWIGTYPE_p_std__vectorT_LandmarkDetector__CLNF_t.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CLNF_hierarchical_models_get(swigCPtr);
                SWIGTYPE_p_std__vectorT_LandmarkDetector__CLNF_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_LandmarkDetector__CLNF_t(cPtr, false);
                return ret;
            }
        }

        public StringList hierarchical_model_names
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_hierarchical_model_names_set(swigCPtr, StringList.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CLNF_hierarchical_model_names_get(swigCPtr);
                StringList ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringList(cPtr, false);
                return ret;
            }
        }

        public SWIGTYPE_p_std__vectorT_std__vectorT_std__pairT_int_int_t_t_t hierarchical_mapping
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_hierarchical_mapping_set(swigCPtr, SWIGTYPE_p_std__vectorT_std__vectorT_std__pairT_int_int_t_t_t.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CLNF_hierarchical_mapping_get(swigCPtr);
                SWIGTYPE_p_std__vectorT_std__vectorT_std__pairT_int_int_t_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_std__vectorT_std__pairT_int_int_t_t_t(cPtr, false);
                return ret;
            }
        }

        public SWIGTYPE_p_std__vectorT_FaceModelParameters_t hierarchical_params
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_hierarchical_params_set(swigCPtr, SWIGTYPE_p_std__vectorT_FaceModelParameters_t.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CLNF_hierarchical_params_get(swigCPtr);
                SWIGTYPE_p_std__vectorT_FaceModelParameters_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_FaceModelParameters_t(cPtr, false);
                return ret;
            }
        }

        public SWIGTYPE_p_cv__CascadeClassifier face_detector_HAAR
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_face_detector_HAAR_set(swigCPtr, SWIGTYPE_p_cv__CascadeClassifier.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__CascadeClassifier ret = new SWIGTYPE_p_cv__CascadeClassifier(LandmarkDetectorPINVOKE.CLNF_face_detector_HAAR_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public string face_detector_location
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_face_detector_location_set(swigCPtr, value);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                string ret = LandmarkDetectorPINVOKE.CLNF_face_detector_location_get(swigCPtr);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public SWIGTYPE_p_dlib__frontal_face_detector face_detector_HOG
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_face_detector_HOG_set(swigCPtr, SWIGTYPE_p_dlib__frontal_face_detector.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_dlib__frontal_face_detector ret = new SWIGTYPE_p_dlib__frontal_face_detector(LandmarkDetectorPINVOKE.CLNF_face_detector_HOG_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public DetectionValidator landmark_validator
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_landmark_validator_set(swigCPtr, DetectionValidator.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CLNF_landmark_validator_get(swigCPtr);
                DetectionValidator ret = (cPtr == global::System.IntPtr.Zero) ? null : new DetectionValidator(cPtr, false);
                return ret;
            }
        }

        public bool detection_success
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_detection_success_set(swigCPtr, value);
            }
            get
            {
                bool ret = LandmarkDetectorPINVOKE.CLNF_detection_success_get(swigCPtr);
                return ret;
            }
        }

        public bool tracking_initialised
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_tracking_initialised_set(swigCPtr, value);
            }
            get
            {
                bool ret = LandmarkDetectorPINVOKE.CLNF_tracking_initialised_get(swigCPtr);
                return ret;
            }
        }

        public double detection_certainty
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_detection_certainty_set(swigCPtr, value);
            }
            get
            {
                double ret = LandmarkDetectorPINVOKE.CLNF_detection_certainty_get(swigCPtr);
                return ret;
            }
        }

        public bool eye_model
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_eye_model_set(swigCPtr, value);
            }
            get
            {
                bool ret = LandmarkDetectorPINVOKE.CLNF_eye_model_get(swigCPtr);
                return ret;
            }
        }

        public IntMatList triangulations
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_triangulations_set(swigCPtr, IntMatList.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CLNF_triangulations_get(swigCPtr);
                IntMatList ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntMatList(cPtr, false);
                return ret;
            }
        }

        public SWIGTYPE_p_cv__Mat_T_double_t detected_landmarks
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_detected_landmarks_set(swigCPtr, SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Mat_T_double_t ret = new SWIGTYPE_p_cv__Mat_T_double_t(LandmarkDetectorPINVOKE.CLNF_detected_landmarks_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public double model_likelihood
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_model_likelihood_set(swigCPtr, value);
            }
            get
            {
                double ret = LandmarkDetectorPINVOKE.CLNF_model_likelihood_get(swigCPtr);
                return ret;
            }
        }

        public SWIGTYPE_p_cv__Mat_T_double_t landmark_likelihoods
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_landmark_likelihoods_set(swigCPtr, SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Mat_T_double_t ret = new SWIGTYPE_p_cv__Mat_T_double_t(LandmarkDetectorPINVOKE.CLNF_landmark_likelihoods_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public int failures_in_a_row
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_failures_in_a_row_set(swigCPtr, value);
            }
            get
            {
                int ret = LandmarkDetectorPINVOKE.CLNF_failures_in_a_row_get(swigCPtr);
                return ret;
            }
        }

        public SWIGTYPE_p_cv__Mat_T_uchar_t face_template
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_face_template_set(swigCPtr, SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Mat_T_uchar_t ret = new SWIGTYPE_p_cv__Mat_T_uchar_t(LandmarkDetectorPINVOKE.CLNF_face_template_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public SWIGTYPE_p_cv__Point_T_double_t preference_det
        {
            set
            {
                LandmarkDetectorPINVOKE.CLNF_preference_det_set(swigCPtr, SWIGTYPE_p_cv__Point_T_double_t.getCPtr(value));
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Point_T_double_t ret = new SWIGTYPE_p_cv__Point_T_double_t(LandmarkDetectorPINVOKE.CLNF_preference_det_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public CLNF() : this(LandmarkDetectorPINVOKE.new_CLNF__SWIG_0(), true)
        {
        }

        public CLNF(string fname) : this(LandmarkDetectorPINVOKE.new_CLNF__SWIG_1(fname), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public CLNF(CLNF other) : this(LandmarkDetectorPINVOKE.new_CLNF__SWIG_2(CLNF.getCPtr(other)), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool DetectLandmarks(SWIGTYPE_p_cv__Mat_T_uchar_t image, SWIGTYPE_p_FaceModelParameters arg1)
        {
            bool ret = LandmarkDetectorPINVOKE.CLNF_DetectLandmarks(swigCPtr, SWIGTYPE_p_cv__Mat_T_uchar_t.getCPtr(image), SWIGTYPE_p_FaceModelParameters.getCPtr(arg1));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SWIGTYPE_p_cv__Mat_T_double_t GetShape(double fx, double fy, double cx, double cy)
        {
            SWIGTYPE_p_cv__Mat_T_double_t ret = new SWIGTYPE_p_cv__Mat_T_double_t(LandmarkDetectorPINVOKE.CLNF_GetShape(swigCPtr, fx, fy, cx, cy), true);
            return ret;
        }

        public SWIGTYPE_p_cv__Rect_T_double_t GetBoundingBox()
        {
            SWIGTYPE_p_cv__Rect_T_double_t ret = new SWIGTYPE_p_cv__Rect_T_double_t(LandmarkDetectorPINVOKE.CLNF_GetBoundingBox(swigCPtr), true);
            return ret;
        }

        public void Reset()
        {
            LandmarkDetectorPINVOKE.CLNF_Reset__SWIG_0(swigCPtr);
        }

        public void Reset(double x, double y)
        {
            LandmarkDetectorPINVOKE.CLNF_Reset__SWIG_1(swigCPtr, x, y);
        }

        public void Read(string name)
        {
            LandmarkDetectorPINVOKE.CLNF_Read(swigCPtr, name);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Read_CLNF(string clnf_location)
        {
            LandmarkDetectorPINVOKE.CLNF_Read_CLNF(swigCPtr, clnf_location);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
