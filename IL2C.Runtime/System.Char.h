#ifndef __System_Char_H__
#define __System_Char_H__

#pragma once

#include <il2c.h>

#ifdef __cplusplus
extern "C" {
#endif

/////////////////////////////////////////////////////////////
// System.Char

typedef wchar_t System_Char;

typedef const struct
{
    /* internalcall */ void* (*IL2C_RuntimeCast)(wchar_t* this__, IL2C_RUNTIME_TYPE_DECL* type);
    System_String* (*ToString)(wchar_t* this__);
    int32_t(*GetHashCode)(wchar_t* this__);
    void(*Finalize)(wchar_t* this__);
    bool(*Equals)(wchar_t* this__, System_Object* obj);
} __System_Char_VTABLE_DECL__;

extern __System_Char_VTABLE_DECL__ __System_Char_VTABLE__;
extern IL2C_RUNTIME_TYPE_DECL __System_Char_RUNTIME_TYPE__;

extern System_String* System_Char_ToString(wchar_t* this__);
extern int32_t System_Char_GetHashCode(wchar_t* this__);
extern bool System_Char_Equals(wchar_t* this__, wchar_t obj);
extern bool System_Char_Equals_1(wchar_t* this__, System_Object* obj);
extern bool System_Char_TryParse(System_String* s, wchar_t* result);

#ifdef __cplusplus
}
#endif

#endif
