﻿using System.Windows.Media;

namespace MahApps.Metro.IconPacks.Converter
{
    public class PackIconMaterialDesignKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconMaterialDesignKind materialDesignKind)
            {
                PackIconMaterialDesignDataFactory.DataIndex.Value?.TryGetValue(materialDesignKind, out data);
            }
            return data;
        }

        /// <inheritdoc />
        protected override ScaleTransform GetScaleTransform(object iconKind)
        {
            return new ScaleTransform(1, -1);
        }
    }
}