﻿Shader "Custom/My First Shader" {

    Properties {
        _Tint ("Tint", Color) = (1, 1, 1, 1)
    }
    
    SubShader {
        Pass {
            CGPROGRAM
            
            #pragma vertex MyVertexProgram
            #pragma fragment MyFragmentProgram
            
            #include "UnityCG.cginc"
            
            float4 _Tint;
            
            float4 MyVertexProgram(float4 position : POSITION) : SV_POSITION {
                return mul(UNITY_MATRIX_MVP, position);
            }
            
            float4 MyFragmentProgram(float4 position : SV_POSITION, float3 localPosition : TEXCOORD0) : SV_TARGET {
                return _Tint;
            }
            
            ENDCG
        }
    }
}