// ***********************************************************************
// Copyright (c) 2017 Unity Technologies. All rights reserved.
//
// Licensed under the ##LICENSENAME##.
// See LICENSE.md file in the project root for full license information.
// ***********************************************************************

%ignore LockAccessStatus;
%ignore FbxLayerElementArray;
%ignore FbxLayerElementArrayReadLock;
%ignore FbxLayerElementArrayTemplate;
%ignore FbxLayerElementMaterial;
%ignore LayerElementArrayProxy;
%ignore FbxLayerElementPolygonGroup;
%ignore FbxLayerElementVertexColor;
%ignore FbxLayerElementUserData;
%ignore FbxLayerElementSmoothing;
%ignore FbxLayerElementCrease;
%ignore FbxLayerElementHole;
%ignore FbxLayerElementVisibility;
%ignore FbxLayerElementTexture;
%ignore FBXSDK_LAYER_ELEMENT_CREATE_DECLARE;
%ignore FBXSDK_FOR_EACH_TEXTURE;
%ignore FBXSDK_FOR_EACH_NON_TEXTURE;
%ignore FBXSDK_TEXTURE_INDEX;
%ignore FBXSDK_TEXTURE_TYPE;
%ignore FBXSDK_NON_TEXTURE_INDEX;
%ignore FBXSDK_NON_TEXTURE_TYPE;
%ignore FbxRefPtr;
%ignore FbxLayerElementArrayPtr;
%ignore FbxSurfaceMaterialPtr;
%ignore FbxTexturePtr;
%ignore FbxGeometryElement;
%ignore FbxGeometryElementNormal;
%ignore FbxGeometryElementBinormal;
%ignore FbxGeometryElementTangent;
%ignore FbxGeometryElementMaterial;
%ignore FbxGeometryElementPolygonGroup;
%ignore FbxGeometryElementUV;
%ignore FbxGeometryElementVertexColor;
%ignore FbxGeometryElementUserData;
%ignore FbxGeometryElementSmoothing;
%ignore FbxGeometryElementCrease;
%ignore FbxGeometryElementHole;
%ignore FbxGeometryElementVisibility;
%ignore FbxTypeOf;
%ignore RemapIndexArrayTo;
%ignore FbxGetDirectArray; 

%rename("$ignore", regextarget=1, fullname=1) "FbxLayerElementNormal::.*";
%rename("$ignore", regextarget=1, fullname=1) "FbxLayerElementBinormal::.*";
%rename("$ignore", regextarget=1, fullname=1) "FbxLayerElementTangent::.*";
%rename("$ignore", regextarget=1, fullname=1) "FbxLayerElementUV::.*";

// ignore what we don't need in FbxLayer
%rename("$ignore", regextarget=1, fullname=1) "FbxLayer::.*";

// unignore what we do need
%rename("%s") FbxLayer::SetNormals;
%rename("%s") FbxLayer::SetBinormals;
%rename("%s") FbxLayer::SetVertexColor;
%rename("%s") FbxLayer::SetUVs;
%rename("%s") FbxLayer::SetTangents;

// ignore what we don't need for FbxLayerElementTemplate and FbxLayerElement
%rename("$ignore", regextarget=1, fullname=1) "FbxLayerElementTemplate::.*";
// don't ignore enum items (will only show up in C# if we unignore the enum itself)
%rename("$ignore", "not" %$isenumitem, regextarget=1, fullname=1) "FbxLayerElement::.*";

// unignore enum that we need
%rename("%s") "FbxLayerElement::EType";


%include "fbxsdk_csharp-fixed-headers/fbxlayer.h"

// create templates that are used as base classes
%template(FbxLayerElementTemplateFbxVector4) FbxLayerElementTemplate<FbxVector4>;
%template(FbxLayerElementTemplateFbxVector2) FbxLayerElementTemplate<FbxVector2>;
