
// MFCApplicationOIDCDlg.h : header file
//

#pragma once


// CMFCApplicationOIDCDlg dialog
class CMFCApplicationOIDCDlg : public CDialogEx
{
// Construction
public:
	CMFCApplicationOIDCDlg(CWnd* pParent = nullptr);	// standard constructor
	// Data member for the .NET User Control:
	CWinFormsControl<WindowsFormsControlLibrary1::UserControl1> m_oCtrl1;

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MFCAPPLICATIONOIDC_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
};
