   M S B A M L   `   `   `  ����N  JAppDireccionGeneral, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AppDireccionGeneral.vistaAppDireccionGeneral.vista  5   	   +    %AppDireccionGeneral.vista.CrudUsuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AppDireccionGeneral.vista     5   	     � Title$  CrudUsuario��5   	   $��506.25��6   $	��971��6-   .��5	      � $��0,0,2,6q�6   .+�5
   
   �� ���	#FF515151$
��Left=�6%   $��56��6@   
�������$	��Top=�6[   $	��973��6s   �� 5   
   ���	#FF8B8B8B$
��Left=�6%   $	��466��6@   
�������$	��Top=�6\   $��49��6t   �� 5   
   $��Usuario��6   $
��Left=�6"   $��	418,0,0,0q�6=   $	��Top=�6P   $��30(�6h   
�������6v   �� 5   
   -   5         ��Name$ Btn_Regresar��5      $��Regresar��6'   $
��Left=�6:   $��	66,10,0,0q�6U   $	��Top=�6h   $	��100��6�   $��20(�6�   $��39��6�   ���	#FF431668 J� RenderTransformOrigin$ -1.292,-3.123&�6�   
�������6�   �� 5   
   -   5        $ Btn_Registrar��5      $��	Registrar��6(   $
��Left=�6<   $��34��6W   $��
543,81,0,0q�6c   $	��Top=�6w   $	��110��6�   $��20(�6�   
����������	#FF0087256�   �� 5   
   -   5         ��Name$ listaUsuarios��5      $��66,152,19,32q�6*   $��0��6@    �� View 5      �� 5      .P�5      �� $��Usuario��6%    �� Width$	 150��66    �� DisplayMemberBinding 6B   �� *NombreUsuario+�� 5      $��Nombre��6%   $	 150��65    6A   �� *Nombre+�� 5      $��Apellido paterno��6%   $	 150��6?    6K   �� *ApellidoPaterno+�� 5      $��Apellido materno��6%   $	 150��6?    6K   �� *ApellidoMaterno+�� 5      $��Cargo��6%   $	 150��64    6@   �� *Cargo+�� 5      $��
Delegacion��6%   $	 150��69    6E   �� *
Delegacion+5      5      �� 5   
   -   5        $ Btn_Modificar��5      {�.  $��	Modificar��6:   $
��Left=�6N   $��34��6i   $��
695,81,0,0q�6u   $	��Top=�6�   $	��110��6�   $��20(�6�   
����������	#FF876E006�   �� 5   
   -   5        $ Btn_Eliminar��5      {�.  $��Eliminar��69   $
��Left=�6L   $��34��6g   $��
840,81,0,0q�6s   $	��Top=�6�   $	��110��6�   $��20(�6�   
����������	#FF8712006�   �� 5   
   $��Usuarios existentes:��6   $
��Left=�6/   $��	66,81,0,0q�6J   $	��Top=�6]   $	��345��6u   $��36(�6�   5      5      