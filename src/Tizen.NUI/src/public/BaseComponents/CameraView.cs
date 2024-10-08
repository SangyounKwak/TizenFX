/*
 * Copyright(c) 2021 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Tizen.NUI.BaseComponents
{
    /// <summary>
    /// CameraView is a view for camera preview.
    /// </summary>
    /// <since_tizen> 9 </since_tizen>
    public class CameraView : View
    {
        /// <summary>
        /// Enumeration for specifying the display type of the CameraView.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public enum DisplayType
        {
            /// <summary>
            /// The camera view will be displayed using hardware overlay.
            /// </summary>
            Window = 0,   //  HW overlay
            
            /// <summary>
            /// The camera view will be displayed using texture stream.
            /// </summary>
            Image     //  texture stream
        };

        /// <summary>
        /// Creates an initialized CameraView.
        /// </summary>
        /// <param name="handle">Multimedia Camera handle</param>
        /// <param name="type">DisplayType</param>
        /// <since_tizen> 9 </since_tizen>
        public CameraView(global::System.IntPtr handle, DisplayType type = DisplayType.Window) : this(Interop.CameraView.New(handle, (int)type), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal CameraView(CameraView cameraView) : this(Interop.CameraView.NewCameraView(CameraView.getCPtr(cameraView)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal CameraView(global::System.IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn)
        {
        }

        /// <summary>
        /// Called when the camera view needs to be updated if the camera setting is changed.
        /// </summary>
        /// <example>
        /// <code>
        ///  camera = new Tizen.Multimedia.Camera(Tizen.Multimedia.CameraDevice.Front);
        ///  cameraView = new CameraView(overlayCamera.Handle);
        ///  cameraView.Size = new Size(300, 400);
        ///  camera.DisplaySettings.Rotation = Tizen.Multimedia.Rotation.Rotate90;
        ///  cameraView.Update();
        /// </code>
        /// </example>
        /// <since_tizen> 9 </since_tizen>
        public void Update()
        {
            Interop.CameraView.Update(SwigCPtr);
        }

        /// <summary>
        /// Dispose.
        /// </summary>
        /// <param name="type">DisposeTypes</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            base.Dispose(type);
        }

        /// This will not be public opened.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void ReleaseSwigCPtr(System.Runtime.InteropServices.HandleRef swigCPtr)
        {
            Interop.CameraView.DeleteCameraView(swigCPtr);
        }
    }

}
