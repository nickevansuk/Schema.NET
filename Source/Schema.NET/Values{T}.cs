﻿namespace Schema.NET
{
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A single or list of values.
    /// </summary>
    /// <typeparam name="T">The type of the values.</typeparam>
    /// <seealso cref="IValue" />
    public struct Values<T> : IValue
    {
        private readonly T item;
        private readonly List<T> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T}"/> struct.
        /// </summary>
        /// <param name="item">The single item value.</param>
        public Values(T item)
        {
            this.item = item;
            this.list = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Values{T}"/> struct.
        /// </summary>
        /// <param name="list">The list of values.</param>
        public Values(List<T> list)
        {
            this.item = default(T);
            this.list = list;
        }

        /// <summary>
        /// Gets a value indicating whether this instance has a single or list of values.
        /// </summary>
        /// <value><c>true</c> if this instance has at least one value; otherwise, <c>false</c>.</value>
        public bool HasValue => this.list != null || this.HasItem;

        /// <summary>
        /// Gets the single item value.
        /// </summary>
        /// <value>The single item value.</value>
        public T Item => this.item;

        /// <summary>
        /// Gets the list of values.
        /// </summary>
        /// <value>The list of values.</value>
        public List<T> List => this.list;

        /// <summary>
        /// Gets a value indicating whether this instance has a single item value.
        /// </summary>
        /// <value><c>true</c> if this instance has a single item value; otherwise, <c>false</c>.</value>
        private bool HasItem => !EqualityComparer<T>.Default.Equals(this.item, default(T));

        /// <summary>
        /// Performs an implicit conversion from <typeparamref name="T"/> to <see cref="Values{T}"/>.
        /// </summary>
        /// <param name="item">The single item value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T>(T item) => new Values<T>(item);

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{T}"/> to <see cref="Values{T}"/>.
        /// </summary>
        /// <param name="list">The list of values.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Values<T>(List<T> list) => new Values<T>(list);

        /// <summary>
        /// Gets the non-null object representing the instance.
        /// </summary>
        /// <returns>
        /// The non-null object representing the instance.
        /// </returns>
        public object GetObject()
        {
            if (this.list != null)
            {
                return this.list;
            }
            else if (this.HasItem)
            {
                return this.item;
            }

            return null;
        }
    }
}
