   M S B A M L   `   `   `  ����E  ASIGEEA_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:SIGEEA_App.Ventanas_Modales.Personas$SIGEEA_App.Ventanas_Modales.Personas  5   	   T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   >    8SIGEEA_App.Ventanas_Modales.Personas.wnwRegistrarPersona   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:SIGEEA_App.Ventanas_Modales.Personas     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  wnwRegistro��5       � Title$ Registro��5	   	   $��410.282��6   $��764.305��6+    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q   .��5
      � .+�5   
   � -   5         �Name$ 
grdPersona��5      $
��Left=�6#   $	��328��6>   $��	25,32,0,0q�6K   $	��Top=�6^   $	��682��6v   .+�5      �� -   5         ��Name$ 	txbCedula��5      $
��Left=�6)   $��23��6D   $��
177,56,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   $��13.333(�6�   $
��Bold"�6�   �� 5      -   5        $ txbPriNombre��5      $
��Left=�6,   $��23��6G   $��177,108,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   $��13.333(�6�   $
��Bold"�6�   �� 5      -   5        $ txbSegNombre��5      $
��Left=�6,   $��23��6G   $��177,155,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   $��13.333(�6�   $
��Bold"�6�   �� 5      -   5        $ txbPriApellido��5      $
��Left=�6.   $��23��6I   $��177,214,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   $��13.333(�6�   $
��Bold"�6�   �� 5      -   5        $ txbSegApellido��5      $
��Left=�6.   $��23��6I   $��177,269,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   $��13.333(�6�   $
��Bold"�6�   �� 5      -   5         ��Name$ 	lblCedula��5      $��Cédula��6'   $
��Left=�68   $��5,56,0,0q�6S   $	��Top=�6e   $��16(�6}   $
��Bold"�6�   �� 5      -	   5        $ lblPriNombre��5      $��Primer nombre��6*   $
��Left=�6B   $��	5,103,0,0q�6]   $	��Top=�6p   $��16(�6�   $
��Bold"�6�   �� 5      -
   5        $ lblSegNombre��5      $��Segundo nombre��6*   $
��Left=�6C   $��	5,155,0,0q�6^   $	��Top=�6q    J� RenderTransformOrigin$ 0.538,0.788&�6�   $��16(�6�   $
��Bold"�6�   �� 5      -   5        $ lblPriApellido��5      $��Primer apellido��6,   $
��Left=�6F   $��	5,214,0,0q�6a   $	��Top=�6t   $��16(�6�   $
��Bold"�6�   �� 5      -   5        $ lblSegApellido��5      $��Segundo apellido��6,   $
��Left=�6G   $��	5,269,0,0q�6b   $	��Top=�6u   $��16(�6�   $
��Bold"�6�   �� 5      -   5        $ 	lblGenero��5      $��Género��6'   $
��Left=�68   $��
374,94,0,0q�6S   $	��Top=�6g   $��16(�6   $
��Bold"�6�   �� 5      -   5        	 ��Name$	 	cbxGenero��5      $
��Left=�6*   $��
521,94,0,0q�6E   $	��Top=�6Y   $	��120��6q   $
��Bold"�6}   $��13.333(�6�   .@�5      �� -   5        
 ��Name$
 cbiMasculino��5      $��M��65   �� 5      -   5        $
 cbiFemenino��5      $��F��64   5      �� 5      -   5        $	 cbxNacionalidad��5      $
��Left=�60   $��521,155,0,0q�6K   $	��Top=�6`   $	��120��6x   $��13.333(�6�   $
��Bold"�6�   �� 5      -   5        $ lblGenero_Copy��5      $��Nacionalidad��6,   $
��Left=�6C   $��374,155,0,0q�6^   $	��Top=�6s   $��16(�6�   $
��Bold"�6�   �� 5      -   5        $ lblGenero_Copy1��5      $��Fec. Nacimiento��6-   $
��Left=�6G   $��374,214,0,0q�6b   $	��Top=�6w   $��16(�6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dtpFecNacimiento��5      $
��Left=�63   $��521,222,0,0q�6N   $	��Top=�6c   $	��120��6{   �� 5      -   5         ��Name$ btnSiguiente��5      $��474,261,140,10q�6+      MetroCircleButtonStyle#���   6C    � Cursor$
 Hand��6t   .��5       �� $��20��6   $��20��6'   ��63   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5!      !� 5"       j� Stretch$
 Fill=�6&     appbar_navigate_next !� Visual# �  5#      5%      5&      �� 5'      -   5         ��Name$ 	textBlock��5'      $
��Left=�6+   $��5,0,0,0q�6F   $
��Wrap=�6W   $��Información personal��6k   $	��Top=�6�   $��	Underline{�6�   $
��Bold"�6�   $��26.667(�6�   5(      � 5)   
   -   5        $��grdEmpleado��5)   n   $
��Left=�6   $	��328��6*   $��	25,32,0,0q�67   $	��Top=�6J   $	��708��6b   $y�	Collapsed=�6�   .+�5*      �� -   5        $ 
textBlock1��5*      $
��Left=�6,   $��	10,10,0,0q�6G   $
��Wrap=�6Z   $��Escolaridad��6n   $	��Top=�6�   $��24(�6�   $
��Bold"�6�   $��	Underline{�6�   �� 5+      -   5        $	 cmbGradoAcad��5+      $
��Left=�6-   $��
10,165,0,0q�6H   $	��Top=�6\   $	��152��6t   $
��Bold"�6�   $��18.667(�6�    �� Text$ Grado académico��6�   .@�5,      �� $��Primaria incompleta��6   6?   �� 5-      $��Primaria completa��6   6=   �� 5.      $��Secundaria incompleta��6   6A   �� 5/      $��Secundaria completa��6   6?   �� 50      $��Universidad incompleta��6   6B   �� 51      $��Universidad completa��6   6@   52      �� 53      -   5        $ label��53      $��Observaciones adicionales��6#   $
��Left=�6G   $��
10,216,0,0q�6b   $	��Top=�6v   $��18.667(�6�   $
��Bold"�6�   �� 54      -   5        $ txbAdicional��54      $
��Left=�6,   $��67��6G   $��
10,251,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��232��6�    �� 	MaxLength$	 300��6�    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6�   �� 55      -   5        $ btnRegistrar��55      $��480,123,144,137q�6+   #���   6D   $
 Hand��6u   .��56      �� $��20��6   $��20��6'   ��63   �� *
Foreground+ �� *FindAncestor+" �� 57      !� 58      $
 Fill=�6&     appbar_save# �  59      5;      5<      �� 5=      -   5         ��Name$ chkLeer��5=      $��	Sabe leer��6(   $
��Left=�6<   $��	10,65,0,0q�6W   $	��Top=�6j   $��18.667(�6�   $
��Bold"�6�   �� 5>      -   5        $ chkEscribir��5>      $��Sabe escribir��6,   $
��Left=�6D   $��
10,109,0,0q�6_   $	��Top=�6s   $��18.667(�6�   $
��Bold"�6�   5?      5@      5A      