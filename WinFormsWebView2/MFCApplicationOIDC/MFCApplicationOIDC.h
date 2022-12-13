
// MFCApplicationOIDC.h : main header file for the PROJECT_NAME application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'pch.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CMFCApplicationOIDCApp:
// See MFCApplicationOIDC.cpp for the implementation of this class
//

class CMFCApplicationOIDCApp : public CWinApp
{
public:
	CMFCApplicationOIDCApp();

// Overrides
public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern CMFCApplicationOIDCApp theApp;
