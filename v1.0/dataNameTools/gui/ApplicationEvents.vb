﻿'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''Copyright (C) 2010 MapAction UK Charity No. 1075977
''
''www.mapaction.org
''
''This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.
''
''This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
''
''You should have received a copy of the GNU General Public License along with this program; if not, see <http://www.gnu.org/licenses>.
''
''Additional permission under GNU GPL version 3 section 7
''
''If you modify this Program, or any covered work, by linking or combining it with 
''ESRI ArcGIS Desktop Products (ArcView, ArcEditor, ArcInfo, ArcEngine Runtime and ArcEngine Developer Kit) (or a modified version of that library), containing parts covered by the terms of ESRI's single user or concurrent use license, the licensors of this Program grant you additional permission to convey the resulting work.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports ESRI.ArcGIS.esriSystem

Namespace My

    Partial Friend Class MyApplication

        Private m_AOLicenseInitializer As LicenseInitializer = New gui.LicenseInitializer()
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            'ESRI License Initializer generated code.
            m_AOLicenseInitializer.InitializeApplication(New esriLicenseProductCode() {esriLicenseProductCode.esriLicenseProductCodeArcEditor, esriLicenseProductCode.esriLicenseProductCodeArcInfo}, _
            New esriLicenseExtensionCode() {})
        End Sub

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            'ESRI License Initializer generated code.
            'Do not make any call to ArcObjects after ShutDownApplication()
            m_AOLicenseInitializer.ShutdownApplication()
        End Sub
    End Class

End Namespace

