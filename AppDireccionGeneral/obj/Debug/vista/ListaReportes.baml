   M S B A M L   `   `   `  ����N  JAppDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AppDireccionGeneral.vistaAppDireccionGeneral.vista  5   	   -    'AppDireccionGeneral.vista.ListaReportes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AppDireccionGeneral.vista     5   	     � Title$  ListaReportes��5   	   $	��450��6   $	��900��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   � ���#353535$��0��6$   .+�5      �� -   5         ��Name$ btnCancelar��5      $��Cancelar��5      $��Center=�5      $
��Left=�5      $��10,0,0,0q�5      $��30��5      $��70��5      
���  ��
�������5   (   5      � 5   
   $��0��6   .+�5      �� $��Lista de reportes��6   
�������$��Center=�6C   $��0,10,0,0q�6^   $��Center=�6p   $��Bell MT)�6�   $��24(�6�   $
��Bold"�6�   �� 5      $��/images/logoSSP.png��6   $��Right=�61   5      �� 5   
   $��1��5        �� Orientation$ 
Horizontal=�5!      $��Center=�5"      $��Center=�5#      .+�5$      �� $��Center=�5%      $��Center=�5&      $��0,0,20,0q�5'      .+�5(      �� $��Estatus:��6   $��Bell MT)�5)      $��18(�6)   �� 5*      -   5         ��Name$ 	cbEstatus��5*      $	��120��5+      .@�5,      �� $��	Pendiente��6#   �� 5-      $��Dictaminado��6#   5.      5/      �� 50      $��Center=�51      $��Center=�52      $��0,0,20,0q�53      .+�54      �� $��Fecha:��6   $��Bell MT)�55      $��18(�6)   (  "System.Windows.Controls.DatePicker  56      -   5          Name$ dpFecha��56      57      �� 58      $��Center=�59      $��Center=�5:      $��0,0,20,0q�5;      .+�5<      �� $��Delegación:��6   $��Bell MT)�5=      $��18(�6)   �� 5>      -   5        $ cbDelegacion��5>      $	��180��61   5?      �� 5@      -   5        $ 
btnFiltrar��5@      $��Filtrar��5A      $��65��5B      $��20��5C      $��0,0,20,0q�5D      6'   �� 5E      -   5        $ btnMostrarTodo��5E      $��Mostrar todo��5F      $��80��5G      $��20��5H      6!   5I      � 5K   
   $��2��6    � ColumnDefinitions 5L      �� 5M      $
��135* �6#   �� 5N      $
��311* �6#   .+�5P      �� -   5         ��Name$ 
lvReportes��5P      $��15q�6,   $��2��6e    �� View 5Q      �� 5R      .P�5S      �� $��Folio��6)   	 �� Width$		 100��6c   
 �� DisplayMemberBinding
 68   �� *	IdReporte+6c   �� 5T      $��Fecha��6)   $		 100��6c   
 68   �� *	FechaHora+6c   �� 5U      $��Estatus��6)   $		 100��6c   
 6:   �� *	Estatus+6c   �� 5V      $��Delegación��6)   $		 300��6o   
 6=   �� *NombreDelegacion+6o   �� 5W      $��
Dirección��6)   $		 300��6p   
 6<   �� *DireccionSiniestro+6p   5X      5Z      5[      �� 5]   
   $��3��6   $��Center=�5^      $��Center=�5_      $ 
Horizontal=�5`      .+�5a      �� -   5        $ btnVerDetalles��5a      $��Ver detalles��5b      {�.  
�������
�������$��30��5f      $��80��5g      $��0,0,20,0q�5h      6'   �� 5i      -	   5        $ btnDictaminar��5i      $��
Dictaminar��5j      {�.  
�������
�������$��30��5n      $��80��5o      6    5p      5q      5s      