   M S B A M L   `   `   `  ����  GestionAvituallamientos?    9GestionAvituallamientos.Vista.GestionAltaAvituallamientos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$!  GestionAltaAvituallamientos��5   	   $��412.8��6-   $	��376��6<   .��5      � ���	#FFEDEDED.+�5   
   �� -   5         ��Name$ lNombreCarrera��5      $��Nombre carrera: ��6(   $
��Left=�6C   $��24��6^   $��	23,37,0,0q�6j   $	��Top=�6}   $��95��6�   �� 5   
   -   5         ��Name$ tbNombreCarrera��5      $��24��6�   $��128,37,28.6,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   ��6P   ��  �� Path$ Nombre� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6�   �� 5   
   -   5         ��Name$ btAltaCarrera��5      $��Añadir carrera��6(   $��246,202,31.6,0q�6A   $��21��6Y   $	��Top=�6e   6}   �� 5	   
   -   5        $ bttBorrarCarrera��5	      $��Borrar carrera��6+   $
��Left=�6D   $��126,202,0,0q�6_   $	��Top=�6t   $	��115��6�   $��21��6�   6�   �� 5
   
   $��CARRERAS EXISTENTES��6   $
��Left=�6.   $��26��6I   $��	22,95,0,0q�6U   $	��Top=�6h   $	��316��6�   $��Center=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCarrerasExistentes��5      $
��Left=�6c   $��69��6~   $��
23,124,0,0q�6�   $	��Top=�6�   $	��317��6�   	   
IsReadOnly	 . 
   AutoGenerateColumns
 .  ��61   �� $ Logica.ListaCarreras�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Header$ Nombre Carrera��6~      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ Nombre�   ClipboardContentBinding 6[   Z� 6�   5      �� 5   
   $*��$LISTA AVITUALLAMIENTOS DE LA CARRERA��6   $
��Left=�6?   $��26��6Z   $��
24,232,0,0q�6f   $	��Top=�6z   $	��316��6�   $��Center=�6�     5   
   -   5        $ dgAvituallamientosCarrera��5      
 .  	 . $
��Left=�6�   $��
23,262,0,0q�6�   $	��Top=�6�   $��69��6�   $	��317��6�   ��6d   �� $ ListaAvituallamiento� 5        5       .  $ Punto kilométrico��6�   $ * 6�    6%   �� $ PuntoKilometrico� 6e   Z� 6�   5      �� 5   
   -   5        $ btAddAvituallamiento��5      $��Añadir��6/   $
��Left=�6@   $��261,340,0,0q�6[   $	��Top=�6p   $��78��6�   $��23��6�   6�   �� 5   
   -   5        $$ buttonModificarAvituallamiento��5      $��	Modificar��69   $
��Left=�6M   $��181,340,0,0q�6h   $	��Top=�6}   $��75��6�   $��23��6�   6�   �� 5   
   -	   5        $! buttonBorrarAvituallamiento��5      $��Borrar avituallamiento��66   $
��Left=�6W   $��
23,340,0,0q�6r   $	��Top=�6�   $	��153��6�   $��23��6�   6�   �� 5   
   -
   5        $ 
labelError��5      $�� ��6$   $
��Left=�6/   $��24,3,0,0q�6J   $	��Top=�6\   $	��316��6t   $��35��6�   �� 5   
   $��Ciudad: ��6   $��24,68,251.6,0q�6#   $	��Top=�6:    J� RenderTransformOrigin$ 0.031,0.023&�6R   �� 5   
   $
��Left=�6   $��23��6-   $��
128,68,0,0q�69   $
 Wrap=�6M   $	��Top=�6a   $��70��6y   5      5      